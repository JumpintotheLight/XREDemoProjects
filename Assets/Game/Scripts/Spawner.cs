using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {
	
	public GameObject prefab;
	public Transform planet;
	public float delay = 2.0f;
	public int spawnPerWave = 3;
	public float spawnSpace = 5f; //space spawner needs to move before spawning
	Vector3 lastSpawnPos; //last spawn position used for spawning
	bool wallSpawned = false; //so walls don't spawn twice in a row
	
	float s = .5f;
	
	float[] startPos;
	
	GameObject[] spawnArray;
	public GameObject badguy, wall, juggernaut, healthPU, goldPU;
	
	
	// Use this for initialization
	void Start () {
		startPos = new float[] {0f, s, s*2, s*3, s*4, s*5, s*6, s*7, s*8, s*9, s*10, s*11, s*12, s*13, s*14, s*15, s*16, s*17, s*18, s*19,
								-s, -s*2, -s*3, -s*4, -s*5, -s*6, -s*7, -s*8, -s*9, -s*10, -s*11, -s*12, -s*13, -s*14, -s*15, -s*16, -s*17, -s*18, -s*19};
		spawnArray = new GameObject[] {badguy, badguy, badguy, badguy, badguy, badguy, badguy,
										juggernaut, juggernaut, juggernaut,
										wall, wall, wall,
										healthPU, goldPU};//things to spawn (keep track of ratios)
		
		lastSpawnPos = transform.position;//save current position for spawning
	}
	
	// Update is called once per frame
	void Update () {

		if(Vector3.Distance(lastSpawnPos, transform.position) >= spawnSpace)//checking distance between last spawn point and current point
		{
			lastSpawnPos = transform.position;//reset last spawn pos
			List<int> posException = new List<int>();//list of spawn points to NOT spawn at
			
			for(int i = 0; i <= spawnPerWave; i++)
			{
				int p = Random.Range(0,spawnArray.Length);//randomly pick which thing to spawn
				GameObject go = SpawnObject(spawnArray[p]);
				
				//GameObject go = Instantiate(spawnArray[p], transform.position, transform.rotation) as GameObject; //spawn thing
				//go.transform.parent = planet; // for rotating and following
				
				//align to planet
				//RaycastHit hit = new RaycastHit();
				//if(Physics.Raycast(new Ray(go.transform.position, -go.transform.up), out hit, 1000f) && go.tag != "PowerUp")
				//{	
				//	go.transform.position = hit.point;
				//}
				
				int n = Random.Range(0,startPos.Length);//randomly pick spawn location
				while(posException.Contains(n))
				{
					n = Random.Range(0,startPos.Length);//repick location because it was excluded
				}
				posException.Add(n);//add position to exclusion list so we dont spawn multiple things on the same spot
				go.transform.RotateAround (Vector3.zero, transform.forward, startPos[n]);//rotate to spawn location
				if(spawnArray[p].tag == "Wall" && !wallSpawned)//if wall is spawned we exclude more points
				{
					GameObject temp = SpawnObject(spawnArray[p]);//spawn other wall
					temp.transform.RotateAround (Vector3.zero, transform.forward, startPos[n] + s*3);//rotate to spawn location
					posException.Add(n+3);//exclude the sides of the wall and the wall covered portion from spawning stuff
					temp = SpawnObject(spawnArray[p]);//spawn other wall
					temp.transform.RotateAround (Vector3.zero, transform.forward, startPos[n] + s*2);//rotate to spawn location
					posException.Add(n+2);
					temp = SpawnObject(spawnArray[p]);//spawn other wall
					temp.transform.RotateAround (Vector3.zero, transform.forward, startPos[n] + s*-1);//rotate to spawn location
					posException.Add(n-1);
					wallSpawned = true;

				}else{
					wallSpawned = false;
				}
				
				
		
			}
		}	

	}
	
	GameObject SpawnObject(GameObject ob)
	{
		GameObject go = Instantiate(ob, transform.position, transform.rotation) as GameObject; //spawn thing
		go.transform.parent = planet; // for rotating and following
		//align to planet
		RaycastHit hit = new RaycastHit();
		if(Physics.Raycast(new Ray(go.transform.position, -go.transform.up), out hit, 1000f) && go.tag != "PowerUp")
		{	
			go.transform.position = hit.point;
		}

		return go;
	}
}

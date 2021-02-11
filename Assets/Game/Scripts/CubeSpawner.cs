using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {
	
	public Transform cube;
	float lowerPitchBound, higherPitchBound, pitchDivision;
	
	// Use this for initialization
	void Start () {
		int x = 10;
		int z = 10;
		int pitchCount = 0;
		lowerPitchBound = .85f;
		higherPitchBound = 1.15f;
		pitchDivision = (higherPitchBound - lowerPitchBound)/100;
	
		while(x != 0)
		{
			while(z != 0)
			{
				Transform go = Instantiate(cube, new Vector3(0f + x * 2, 0f, 0f + z * 2), Quaternion.identity) as Transform;
				go.GetComponent<AudioSource>().pitch = .8f + pitchCount * pitchDivision;
				pitchCount++;
				z--;
			}
			z = 10;
			x--;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

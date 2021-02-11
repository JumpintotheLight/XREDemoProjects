using UnityEngine;
using System.Collections;

public class GoldPU : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0f, Mathf.Sin(Time.time * 10f), 0f) * .05f, Space.Self);
	}
	
	void OnTriggerEnter (Collider hit)
	{
		if(hit.tag == "Despawner")//despawn
		{
			Destroy(gameObject);
		}else if(hit.tag == "Player")//attack by player
		{
			AudioSource.PlayClipAtPoint(SoundController.instance.GetPlayerPUCollectSound(), transform.position);
			ScoreKeeper.instance.ChangeScore(10);
			KillSelf();
		}else if(hit.tag == "Enemy")//stomped by Juggs
		{
			KillSelf();
		}
		
	}
	
	void KillSelf()
	{
		Destroy(gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	
	public Transform ball1, ball2;
	Vector3 start, end;
	
	// Use this for initialization
	void Start () {
		start = ball1.position;
		end = ball2.position;
		StartCoroutine(BallMove());
	}
	
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(ball1.position, ball2.position) < 2.2f)
		{
			PlaySound();
		}
	}
	
	IEnumerator BallMove()
	{
		while(true)
		{
			float time = 0f;
			while(time < 1f)
			{
				time += Time.deltaTime;
				ball1.position = Vector3.Lerp(start, end, time);
				ball2.position = Vector3.Lerp(end, start, time);
//				if(time > .48f && time < .52f)
//				{
//					PlaySound();
//				}
				
				yield return 0;
			}
			while(time > 0f)
			{
				time -= Time.deltaTime;
				ball1.position = Vector3.Lerp(start, end, time);
				ball2.position = Vector3.Lerp(end, start, time);
//				if(time > .48f && time < .52f)
//				{
//					PlaySound();
//				}
				yield return 0;
			}
		}
	}
	
	void PlaySound()
	{
		if(!GetComponent<AudioSource>().isPlaying)
		{
			GetComponent<AudioSource>().Play();
		}
	}
}

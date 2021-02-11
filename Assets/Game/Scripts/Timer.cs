using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(TimerCoroutine());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator TimerCoroutine()
	{
		print("0 seconds");
		yield return 0;
		print ("frame passed");
		
		yield return new WaitForSeconds(10f);
		print ("waited 10 seconds");
	}
}

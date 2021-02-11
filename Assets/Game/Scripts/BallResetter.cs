using UnityEngine;
using System.Collections;

public class BallResetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		BallController script = other.GetComponent<BallController>();

		script.hit = false;
	
	}
}


using UnityEngine;
using System.Collections;

public class camtimer : MonoBehaviour {
	float p;
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().time = 3f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

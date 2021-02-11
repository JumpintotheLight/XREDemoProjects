using UnityEngine;
using System.Collections;

public class cylinderShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().useGravity = true;
		GetComponent<Rigidbody>().AddForce(-100000f,0f,0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

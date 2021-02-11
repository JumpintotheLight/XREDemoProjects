using UnityEngine;
using System.Collections;

public class Antigravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerStay(Collider obj)
	{
		obj.GetComponent<Rigidbody>().AddForce(Time.deltaTime * 100, Time.deltaTime * 1000f, 0f);
	}
}

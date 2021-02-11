using UnityEngine;
using System.Collections;

public class rocketforce : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce(0f,20f,0f);
		if(transform.position.y >= 23)
		{
			
			Destroy(this.gameObject);
		}
	}
}

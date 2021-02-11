using UnityEngine;
using System.Collections;

public class lightmove : MonoBehaviour {


	float initial_height = 1;
	// Use this for initialization
	void Start () {
		initial_height = transform.position.y; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Sin(Time.time * 10f), initial_height, Mathf.Cos(Time.time * 10f));
		
	}
}

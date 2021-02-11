using UnityEngine;
using System.Collections;

public class SmoothMove : MonoBehaviour {
	
	Vector3 target;
	
	// Use this for initialization
	void Start () {
		target = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			target += -transform.right;
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			target += transform.right;
		}
		
		transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * 5);
	}
}

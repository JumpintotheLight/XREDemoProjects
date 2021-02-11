using UnityEngine;
using System.Collections;

public class MazeSolver : MonoBehaviour {
	
	public float speed = 5f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
		
		Ray ray = new Ray(transform.position, transform.forward);
		
		if(Physics.Raycast(ray, 1f))
		{
			transform.Rotate(0f,90f,0f);
		}
	}
}

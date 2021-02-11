using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour
{
	public Transform target; 
	public float amplitude = 10f; 
	public float rotation_speed = 10f; 
	float initial_height = 1;
	// Use this for initialization
	void Start()
	{
		initial_height = transform.position.y;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = new Vector3(amplitude * Mathf.Sin(Time.time * rotation_speed), initial_height, amplitude * Mathf.Cos(Time.time * rotation_speed));
		transform.LookAt(target);
	}
}
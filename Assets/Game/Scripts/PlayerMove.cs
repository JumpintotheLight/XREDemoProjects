using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {//mover for player to follow

	public float speed = .5f;
	public Transform planet;
	
	public float speedIncDelay = 10f;
	float speedIncTimer = 10f;
	public float speedIncrease = .1f;
	public float maxSpeed = 4.5f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		speedIncTimer -= Time.deltaTime;
		if(speedIncTimer <= 0)
		{
			speedIncTimer = speedIncDelay;
			speed += speedIncrease;
			if(speed > maxSpeed)
			{
				speed = maxSpeed;
			}
		}
		
		transform.RotateAround(Vector3.zero, transform.right, speed * Time.deltaTime);//move along surface of planet
		
		if (Input.GetKeyDown(KeyCode.A))//left
		{
			transform.RotateAround (Vector3.zero, transform.forward, .5f);
		}
        if (Input.GetKeyDown(KeyCode.D))//right
		{
			
			transform.RotateAround (Vector3.zero, transform.forward, -.5f);
		}
	}
}

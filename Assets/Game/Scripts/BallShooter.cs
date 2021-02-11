using UnityEngine;
using System.Collections;

public class BallShooter : MonoBehaviour {
	
	public Transform ball;
	float ballShootCD;
	float shotPower;
	public float force;
	
	// Use this for initialization
	void Start () {
		ballShootCD = .1f;
		shotPower = 0f;
		force = 1000;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
		{
			if(shotPower < 2)
			{
				
				shotPower += Time.deltaTime * 4;
				print (shotPower);
			}
		}
		if(Input.GetMouseButtonUp(0))
		{
			Transform go = Instantiate(ball, transform.position + transform.forward, Camera.main.transform.rotation) as Transform;
			go.GetComponent<Rigidbody>().AddForce(transform.forward * force * shotPower);
			shotPower = 0f;
		}
	}
}

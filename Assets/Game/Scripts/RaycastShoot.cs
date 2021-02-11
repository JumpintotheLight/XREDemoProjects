using UnityEngine;
using System.Collections;

public class RaycastShoot : MonoBehaviour {
	

	
	public float mouseSensitivity = 90f;

	Rigidbody rigidbody; 
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Ray ray =  new Ray(transform.position, -transform.up);
			
			if(Physics.Raycast(ray, 1.1f))
			{
				rigidbody.AddForce(Vector3.up * 200f);
			}
		}
		
		transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime, 0f);
		
		if(Input.GetMouseButtonDown(0))
		{
			Ray shootRay =  new Ray(transform.position, transform.forward);
			RaycastHit hit = new RaycastHit();
			
			if(Physics.Raycast(shootRay, out hit))
			{
				Rigidbody hitVictim = hit.rigidbody;
				hitVictim.AddForce(-hit.normal * 100f);
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class InputGraph : MonoBehaviour {
	
	
	public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
		
		float vertical = Input.GetAxis("Vertical");
		transform.position = new Vector3(transform.position.x, vertical * 5f, transform.position.z);
		
		Camera.main.transform.position = new Vector3( Camera.main.transform.position.x, 0f, Camera.main.transform.position.z);
	}
}

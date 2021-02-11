using UnityEngine;
using System.Collections;

public class PlayerFollower : MonoBehaviour {
	
	public Transform follow; //thing to follow
	public float speed = 10f; //follow speed
	public Transform planet;

	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.rotation = Quaternion.Slerp(transform.rotation, follow.rotation, Time.deltaTime * speed);//rotate to keep aligned with planet
		transform.position = Vector3.Lerp(transform.position, follow.position, Time.deltaTime * speed);//move to object
		
	}
}

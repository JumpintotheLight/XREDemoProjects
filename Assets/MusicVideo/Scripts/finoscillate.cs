using UnityEngine;
using System.Collections;

public class finoscillate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var rot = transform.rotation;
		var angles = rot.eulerAngles;
		angles.y = Mathf.Sin(Time.time*5.2f)*15;
		rot.eulerAngles = angles;
		transform.rotation = rot;
	}
}

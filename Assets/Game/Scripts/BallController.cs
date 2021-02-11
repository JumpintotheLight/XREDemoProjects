using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	
	public bool hit;
	
	// Use this for initialization
	void Start () {
		hit = false;
		Destroy(this.gameObject, 6f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

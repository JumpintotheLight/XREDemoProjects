using UnityEngine;
using System.Collections;

public class particleOn : MonoBehaviour {
	
	Vector3 lastPos;
	public ParticleSystem particles;
	
	// Use this for initialization
	void Start () {
		lastPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position != lastPos)
		{
			particles.Emit(1);
		}else{
			
		}
		lastPos = transform.position;
	}
}

using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	public ParticleSystem explo;
	public Transform text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{
		Instantiate(text);
		explo.Play();
	}
}

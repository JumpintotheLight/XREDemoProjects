using UnityEngine;
using System.Collections;
using UnityEditor;
	
public class linemaker : Editor {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnSceneGui()
	{
		Handles.DrawLine(new Vector3(0,0,0), new Vector3(1,1,1));
	}
}

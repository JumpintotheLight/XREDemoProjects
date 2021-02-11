using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour {
	
	Color[] colorArray = new Color[8];
	// Use this for initialization
	void Start () {
		colorArray[0] = Color.blue;
		colorArray[1] = Color.cyan;
		colorArray[2] = new Color(.9f, .5f, .2f);
		colorArray[3] = Color.green;
		colorArray[4] = Color.magenta;
		colorArray[5] = Color.red;
		colorArray[6] = Color.yellow;
		colorArray[7] = new Color(.9f, .9f, .9f);
		GetComponent<Light>().color = colorArray[Random.Range(0,8)];

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		BallController script = other.GetComponent<BallController>();
		if(other.gameObject.tag == "Ball" && !script.hit)
		{
			GetComponent<Light>().color = colorArray[Random.Range(0,8)];
			GetComponent<AudioSource>().Play();
			script.hit = true;
		}
	}

}

using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class DisplayRandomNumber : MonoBehaviour {
	
	int counter;
	public Text text; 
	
	// Use this for initialization
	void Start () {
		text.text="";
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		int number = (int)Mathf.Round(Random.value);
		text.text += number == 0 ? "/" : "\\";
		if(counter == 50)
		{
			text.text += "\n";
			counter =0;
		}
		counter++;
	}
}

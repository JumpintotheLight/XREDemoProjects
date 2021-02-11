using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreText : MonoBehaviour {
	
	public Text gold, highscore;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gold.text = "" + ScoreKeeper.instance.GetScore();
		highscore.text = "" + ScoreKeeper.instance.GetHighScore();
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel ("spheremove");
			
		}
	}
}

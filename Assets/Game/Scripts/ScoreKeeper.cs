using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	
	public static ScoreKeeper instance; // for singleton

	int score = 0;
	static int highScore = 0;
	public Text text; 

	
	// Use this for initialization
	void Start () {
		text.text = "Gold: " + score;
	}
	
	void Awake()
	{
		instance = this;//for singleton
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public int ChangeScore(int mod)
	{
		score += mod;
		if (score < 0)
		{
			score = 0;
		}
		if(score > highScore)
		{
			highScore = score;
		}
		text.text = "Gold: " + score;
		return score;
	}
	
	public int GetScore()
	{
		return score;
	}
	
	public int GetHighScore()
	{
		return highScore;
	}
}

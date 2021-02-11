using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {
	
	public AudioClip[] enemySwordDeathSounds;
	public AudioClip[] enemyArrowDeathSounds;
	public AudioClip[] playerWallHitSounds;
	public AudioClip[] playerPUCollectSounds;
	
	public AudioClip sword1, sword2, sword3, arrow1, arrow2, wallCrash1, pu1, pu2; //list of sounds
	
	public static SoundController instance; // for singleton
	
	// Use this for initialization
	void Start () {
		
		enemySwordDeathSounds = new AudioClip[] {sword1, sword2, sword3};
		enemyArrowDeathSounds = new AudioClip[] {arrow1, arrow2};
		playerWallHitSounds = new AudioClip[] {wallCrash1};
		playerPUCollectSounds = new AudioClip[] {pu1, pu2};
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Awake()
	{
		instance = this;//for singleton
	}
	
	//random getters
	public AudioClip GetEnemySwordDeathSound()
	{
		return enemySwordDeathSounds[Random.Range(0, enemySwordDeathSounds.Length)];
	}
	public AudioClip GetEnemyArrowDeathSound()
	{
		return enemyArrowDeathSounds[Random.Range(0, enemyArrowDeathSounds.Length)];
	}
	public AudioClip GetPlayerWallHitSound()
	{
		return playerWallHitSounds[Random.Range(0, playerWallHitSounds.Length)];
	}
	public AudioClip GetPlayerPUCollectSound()
	{
		return playerPUCollectSounds[Random.Range(0, playerPUCollectSounds.Length)];
	}
}

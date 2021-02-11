using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {
	
	public static HealthController instance; // for singleton
	public int maxHP, currHP;
	public Text text;

	// Use this for initialization
	void Start () {
		maxHP = 100;
		currHP = 100;
		text.text = "HP: " + currHP;
	}
	
	void Awake()
	{
		instance = this;//for singleton
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public int ChangeHP(int mod)
	{
		if(mod <= -50)
		{
			CameraShake.instance.ScreenShake(1f);
		}else if(mod <= -30)
		{
			CameraShake.instance.ScreenShake(.8f);
		}else if (mod < 0)
		{
			CameraShake.instance.ScreenShake(.4f);
		}
		
		currHP += mod;
		if (currHP <= 0)
		{
			Application.LoadLevel ("EndScreen");
			//die
		}
		if (currHP >= maxHP)
		{
			currHP = maxHP;
		}
		text.text = "HP: " + currHP;
		
		if(currHP <= 50)
		{
			BloodSplatterController.instance.StartBlood();
		}else{
			BloodSplatterController.instance.StopBlood();
		}
		
		
		return currHP;
	}
}

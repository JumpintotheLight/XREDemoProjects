using UnityEngine;
using System.Collections;

public class SmoothTurn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			StartCoroutine(Turn (-45f));
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			StartCoroutine(Turn (45f));
		}
	}
	
	IEnumerator Turn (float turnAmount)
	{
		float t = 0f;
		Quaternion startRot = transform.rotation;
		Quaternion endRot = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + turnAmount, transform.eulerAngles.z);
			
		while( t < 1f)
		{
			t += Time.deltaTime / .5f;
			transform.rotation = Quaternion.Slerp(startRot, endRot, t);
			yield return 0;
		}
	}
}

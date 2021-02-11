using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {
	
	public static CameraShake instance; //for singleton
	
	void Awake(){
		instance = this;//for singleton
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void ScreenShake(float dur)
	{
		StartCoroutine( ShakeCoroutine(dur) );
	}	
	
	IEnumerator ShakeCoroutine(float duration) {
        Vector3 basePosition = transform.localPosition;

        float time = 1f;
        float shakeDuration = duration;

        while ( time > 0f ) {
            time -= Time.deltaTime / shakeDuration;
			
			transform.Translate(new Vector3(0f, Mathf.Sin(Time.time * 100f), 0f) * time, Space.Self);
			transform.Translate(new Vector3(Mathf.Sin(Time.time * 100f), 0f, 0f) * time, Space.Self);
			
            //transform.position = basePosition + Mathf.Sin( Time.time * 100f ) * transform.right * time
            //                                  + Mathf.Sin( Time.time * 90f ) * transform.up * time;
            yield return 0; // wait one frame
        }
		transform.localPosition = Vector3.Lerp(transform.localPosition, basePosition, 1f);
    }
}

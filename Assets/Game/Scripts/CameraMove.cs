using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	float rotationY;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate( 0f, -Input.GetAxis( "Mouse X" ), 0f );

        rotationY += Input.GetAxis( "Mouse Y" );
        transform.localEulerAngles = new Vector3( rotationY, transform.localEulerAngles.y, 0f );
		/*if(transform.localEulerAngles.x < 25)
		{
			transform.localEulerAngles = new Vector3( 25f, transform.localEulerAngles.y, 0f );
		}else if(transform.localEulerAngles.x > 89)
		{
			transform.localEulerAngles = new Vector3( 89f, transform.localEulerAngles.y, 0f );
		}*/
	}
}

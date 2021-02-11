using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {
	
	float width = 1.0f;
	Color color = Color.black;
 	public Vector2 scrollPosition = Vector2.zero;
    public GUIStyle style;
	
    void OnGUI() {
		Vector2 pointA = new Vector2(Screen.width/2, Screen.height/2);
    	Vector2 pointB = Event.current.mousePosition;
    	Drawing.DrawLine(pointA, pointB, color, width);
     
    }
}

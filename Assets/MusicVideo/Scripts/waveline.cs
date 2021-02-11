using UnityEngine;
using System.Collections;

public class waveline : MonoBehaviour {
	
  public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    public int lengthOfLineRenderer = 20;

    float initial_height; 
    void Start() {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Legacy Shaders/Particles/Additive"));
        lineRenderer.SetColors(c1, c2);
        lineRenderer.SetWidth(0.2F, 0.2F);
        lineRenderer.SetVertexCount(lengthOfLineRenderer);

        initial_height = transform.position.y; 
    }
    void Update() {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        int i = 0;
        while (i < lengthOfLineRenderer) {
            Vector3 pos = new Vector3(i * 0.5F, Mathf.Sin(i + Time.time), 0) + new Vector3(0, initial_height, 0) ;
            lineRenderer.SetPosition(i, pos);
            i++;
        }
    }
}
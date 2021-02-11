using UnityEngine;
using System.Collections;

public class WaterWaves : MonoBehaviour {

	MeshFilter meshFilter;
	
	float[] random;
	Vector3[] verticesCopy, baseCopy;
	
	// Use this for initialization
	void Start () {
		meshFilter = GetComponent<MeshFilter>();
		
		Mesh mesh = meshFilter.mesh;
		verticesCopy = mesh.vertices;
		baseCopy = mesh.vertices;
		random = new float[mesh.vertexCount];
		for(int i = 0; i < mesh.vertexCount; i++)
		{
			Debug.Log(i.ToString() + mesh.vertices[i].ToString());
			random[i] = Random.Range(0f, .5f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < verticesCopy.Length; i++)
		{
			verticesCopy[i] = baseCopy[i] +  Mathf.Sin(Time.time * random[i] * 5f) * Vector3.up * random[i] * .5f;
		}
		
		meshFilter.mesh.vertices = verticesCopy;
		meshFilter.mesh.RecalculateNormals();
	}
}

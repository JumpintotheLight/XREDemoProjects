using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color color;
    private Renderer rend; 

    public void Start()
    {
        rend = GetComponent<Renderer>(); 

    }

    public void Update()
    {
        
    }


    public void DoSomething()
    {
        rend.material.color = color;
    }

}

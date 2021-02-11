using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject playerPrefab; 
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnPlayer()
    {
        if (player != null)
            Destroy(player); 

        player =  Instantiate(playerPrefab, spawnPoints[Random.Range(0, spawnPoints.Length-1)]); 

    }
}

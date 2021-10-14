using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code was used from https://learn.unity.com/tutorial/lesson-3-3-don-t-just-stand-there?uv=2020.3&courseId=5cf96c41edbc2a2ca6e8810f&projectId=5cf9639bedbc2a2b1fe1e848

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(18, -3, -4);
    private float startDelay = 1.5f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
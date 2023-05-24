using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    
    public GameObject[] newPrefabs;
    private Vector3 spawnPosition = new Vector3(28, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int index = Random.Range(0, newPrefabs.Length);

        if(playerControllerScript.gameOver == false)
        {
            Instantiate(newPrefabs[index], spawnPosition, newPrefabs[index].transform.rotation);
        }
    }
}

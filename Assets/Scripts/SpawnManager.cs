using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject bgObstaclePrefab;
    private Vector3 spawnLocation = new Vector3(30, 0, 0);
    private float initialWait = 2;
    private float periodRepeat = 2;
    private PlayerController playerController;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", initialWait, periodRepeat);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

        int bgBoxCount = 20;
        float bgWidth = GameObject.Find("Background").GetComponent<BoxCollider>().size.x;
        float spacing = bgWidth / bgBoxCount;


        for (int count = 0; count < bgBoxCount; count++)
        {
            Debug.Log(count * spacing);
            Instantiate(bgObstaclePrefab, new Vector3(count * spacing, 0, 4.15f), bgObstaclePrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        // I accidently  put captial 'P' instead of 'p'
        if (playerController.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnLocation, obstaclePrefab.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    Ground groundSpawner;
    GameObject playerRef;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<Ground>();
        SpawnObstacle();
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerExit(Collider other)
    {      
            //groundSpawner.SpawnTile();
            Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Physics.gravity);
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle ()
    {
        int obstacleSpawnIndex = Random.Range(2, transform.childCount);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        if (spawnPoint.childCount > 0)
        {
            for(int i = 0; i < spawnPoint.childCount; i++)
            {
                Instantiate(obstaclePrefab, spawnPoint.GetChild(i).position, Quaternion.identity, transform);
            }      
        }
        else
        {
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    PlayerController playerController;
    GameObject playerRef;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>();
        playerRef = GameObject.FindGameObjectWithTag("Player");
    } 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerRef)
        {
            Debug.Log("Playerdie");
            //Kill player
            playerController.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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
        if(this.tag == "tree")
        {
            this.transform.SetPositionAndRotation(this.transform.position, Quaternion.Euler(Random.Range(-20, 20), Random.Range(0, 360), Random.Range(-5, 5)));
            this.transform.localScale = new Vector3(this.transform.localScale.x, Random.Range(3f, 5f), this.transform.localScale.z);
        }
        
        playerController = GameObject.FindObjectOfType<PlayerController>();
        playerRef = GameObject.FindGameObjectWithTag("Player");
    } 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerRef)
        {
            //Debug.Log("Playerdie");
            //Kill player
            playerController.Die();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

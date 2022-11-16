using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    bool alive = true;
    public Rigidbody rb;
    [SerializeField] float vitesseDeplacement = 5f;
    [SerializeField] float minVelocityZ = 5;
    [SerializeField] GameObject ground;
    [SerializeField] float velocityMax = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //print("en vie : " + alive+" "+ rb.velocity);

        if (rb.velocity.z < minVelocityZ)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, minVelocityZ);
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity += new Vector3(-vitesseDeplacement, 0, 0) * Time.deltaTime;
           

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector3(vitesseDeplacement, 0, 0) * Time.deltaTime;
        }

        if (!alive) return;

        //if (transform.position.y < -5)
        //{
        //    Debug.Log("die");
        //    Die();
        //}


    }
    private void FixedUpdate()
    {
        if(rb.velocity.magnitude > velocityMax)
        {
            rb.velocity = rb.velocity.normalized * velocityMax;
        }
    }
    public void Die ()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

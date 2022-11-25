using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector3 moveVector;
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

        if (!alive) return;
    }
    private void FixedUpdate()
    {

        velocityMax = gameObject.transform.position.z/500f * 10f + 35f;
        Debug.Log(velocityMax);

        if (rb.velocity.z < minVelocityZ)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, minVelocityZ);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity += new Vector3(-vitesseDeplacement, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector3(vitesseDeplacement, 0, 0);
        }

        moveVector.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                rb.velocity += new Vector3(vitesseDeplacement, 0, 0);
                

            }
            else
            {
                rb.velocity += new Vector3(-vitesseDeplacement, 0, 0);
            }
        }

        if (rb.velocity.magnitude > velocityMax)
        {
            rb.velocity = rb.velocity.normalized * velocityMax;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Debug.Log("PlayerOnGround");
            gameObject.transform.GetChild(1).GetComponent<ParticleSystem>().emissionRate = 50;
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.tag == "ground")
        {
            Debug.Log("PlayerOnGround");
            gameObject.transform.GetChild(1).GetComponent<ParticleSystem>().emissionRate = 0;
        }
    }


    public void Die ()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

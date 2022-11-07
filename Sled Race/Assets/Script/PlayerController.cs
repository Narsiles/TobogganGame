using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    bool alive = true;
    public Rigidbody rb;
    [SerializeField] float vitesseDeplacement = 5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!alive) return;


        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity += new Vector3(-vitesseDeplacement, 0, 0) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector3(vitesseDeplacement, 0, 0) * Time.deltaTime;
        }

        if (true)
        {

        }
    }

    public void Die ()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

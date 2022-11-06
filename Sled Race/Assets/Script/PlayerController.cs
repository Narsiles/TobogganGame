using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    [SerializeField] float vitesseDeplacement = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity += new Vector3(-vitesseDeplacement, 0, 0) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector3(vitesseDeplacement, 0, 0) * Time.deltaTime;
        }
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{

    float speed = 30f;
    float sideSpeed = 10f;
    Rigidbody rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0, speed);
        checkInput();
    }

    void checkInput()
    {
        float input = Input.GetAxis("Horizontal") * sideSpeed;
        rb.velocity = new Vector3(input, rb.velocity.y, rb.velocity.z);
    }
}

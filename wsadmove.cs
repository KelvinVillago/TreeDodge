﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wsadmove : MonoBehaviour
{
    public Rigidbody rb;
    //private Vector3 joe;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(1000 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1000 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -100000 * Time.deltaTime);

        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 100000 * Time.deltaTime);

        }


    }
}

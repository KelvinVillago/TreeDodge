﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject p;
    
    private Vector3 pos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = new Vector3(p.transform.position.x, p.transform.position.y + 0.2f, p.transform.position.z + 0.3f);
        transform.position = pos;

        

    }
}

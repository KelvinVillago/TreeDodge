using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecodemover : MonoBehaviour
{
    public Rigidbody rbb;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rbb.AddForce(0, 0, 100 * Time.deltaTime);
    }
}

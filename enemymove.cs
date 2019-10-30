using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public Rigidbody rbb;
    public float sp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(rbb.velocity.z > 0.0f)
        {
            rbb.velocity = new Vector3(0, 0, -10);
        }
        if(rbb.velocity.z > -1)
        {
            rbb.velocity = new Vector3(0, 0, -1);
        }*/
        rbb.AddForce(0, 0, -sp * Time.deltaTime);
    }
}

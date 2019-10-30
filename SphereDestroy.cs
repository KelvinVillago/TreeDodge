using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject self;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > -15)
            
        {
            Destroy(self);
        }
        if(transform.position.z < -50)
        {
            Destroy(self);
        }
    }
}

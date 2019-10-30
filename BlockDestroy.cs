using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject self;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -48)
        {
           Destroy(self);
        }
        if(transform.position.y < -3)
        {
            Destroy(self);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECollision : MonoBehaviour
{
    public GameObject self;
    // Start is called before the first frame update
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
    }
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Bullet")
        {
            Destroy(self);
        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private Vector3 pos;
    private Renderer rend, rend2;
    public Material mat;
    public GameObject self, leaves;
    public Rigidbody r1, r2;

    // Start is called before the first frame update
    void Start()
    {
        rend = self.GetComponent<Renderer>();
        rend2 = leaves.GetComponent<Renderer>();
        r1 = self.GetComponent<Rigidbody>();
        r2 = leaves.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Bullet")
        {
            rend.material = mat;
            rend2.material = mat;

            r1.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            r2.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGun : MonoBehaviour
{

    private Vector3 pos;
    public Rigidbody projectile;
    private float speed = 20;
    public bool complete;
    // Use this for initialization
    void Start()
    {
        complete = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(complete == true)
            StartCoroutine("Shoot");

    }

    IEnumerator Shoot()
    {
        complete = false;
        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.5f);

            //A = new Vector3(3.0f, Spawn.position.y, Spawn.position.z);
            Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                               pos,
                                                               transform.rotation);
            //as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, -speed));
        yield return new WaitForSeconds(2.0f);
        complete = true;
    }

}

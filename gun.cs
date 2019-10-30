using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    public Rigidbody projectile;
    private Quaternion rot;
    public float speed = 20;
    private Vector3 pos;
    public KeyCode k;
    private int ammo;
    private int Press1;
    private bool complete;

    // Use this for initialization
    void Start()
    {
        ammo = 50;
        Press1 = 2;
        complete = true;
    }

    // Update is called once per frame
    void Update()
    {

        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.0f);

        /*
        if (Input.GetKey(k) && (Press1 == 2 || Press1 == 0))
        {
            Press1 = 0;
            StartCoroutine("Shoot");
            //StopCoroutine("Shoot");

        }
        else
        {
            Press1 = 2;
        }

        if (Input.GetKey("w") && (Press1 == 2 || Press1 == 1) && complete && ammo == 0)
        {
            Press1 = 1;
            StartCoroutine("Reload");
            //StopCoroutine("Reload");
        }
        else
        {
            Press1 = 2;
        }*/
        if(complete == true)
            StartCoroutine("Shoot");
    }

    /*IEnumerator Shoot()
    {
        if (ammo > 0)
        {
            rot = new Quaternion(transform.rotation.x, transform.rotation.y + 270.0f, transform.rotation.z, 0.0f);
            pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.5f);

            //A = new Vector3(3.0f, Spawn.position.y, Spawn.position.z);
            Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                               pos,
                                                               projectile.transform.rotation);
                    //as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            ammo = ammo - 1;
            yield return new WaitForSeconds(1.5f);
        }
                
    }
    IEnumerator Reload()
    {
        complete = false;
        yield return new WaitForSeconds(1.0f);
        ammo = 50;
        complete = true;
    }*/

    IEnumerator Shoot()
    {
        complete = false;
        //yield return new WaitForSeconds(1.0f);
        rot = new Quaternion(transform.rotation.x, transform.rotation.y + 270.0f, transform.rotation.z, 0.0f);
        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.5f);

        //A = new Vector3(3.0f, Spawn.position.y, Spawn.position.z);
        Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                           pos,
                                                           projectile.transform.rotation);
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        yield return new WaitForSeconds(0.5f);
        complete = true;
    }

    public int getAmmo()
    {
        return ammo;
    }
}

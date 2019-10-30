using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 pos;
    public ButtonR r;
    public ButtonL l;

    private bool enableL;
    private bool enableR;

    public Material[] mat;

    public KeyCode one;
    public KeyCode two;
    public KeyCode three;
    public KeyCode four;

    private Renderer rend;
    public GameObject self;
    Vector3 movement;
    public int x;

    // Start is called before the first frame update
    void Start()
    {
        rend = self.GetComponent<Renderer>();
        enableL = true;
        enableR = true;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if ((Input.GetKey("d") || r.move == true) && enableR == true)
        {
            rb.AddForce(1000 * Time.deltaTime, 0, 0);
            //transform.Translate(x, 0, 0);
        }
        if ((Input.GetKey("a") || l.move == true) && enableL == true)
        {
             rb.AddForce(-1000 * Time.deltaTime, 0, 0);
            //transform.Translate(-x, 0, 0);
        }

        if (transform.position.x >= 50)
        {
            enableR = false;
            rb.velocity = Vector3.zero;
            pos = new Vector3(50, transform.position.y, transform.position.z);
            transform.position = pos;

        }
        else
        {
            enableR = true;
        }

        if (transform.position.x <= -50)
        {
            
            enableL = false;
            rb.velocity = Vector3.zero;
            pos = new Vector3(-50, transform.position.y, transform.position.z);
            transform.position = pos;
        }
        else
        {
            enableL = true;
        }

        if (Input.GetKey(one))
        {
            rend.material = mat[0];
        }
        if (Input.GetKey(two))
        {
            rend.material = mat[1];
        }
        if (Input.GetKey(three))
        {
            rend.material = mat[2];
        }
        if (Input.GetKey(four))
        {
            rend.material = mat[3];
        }
    }
    
}
 
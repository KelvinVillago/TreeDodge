using UnityEngine;

public class collision : MonoBehaviour
{
    public move move;
    public GameManager gameManager;
    private Rigidbody rb;
    void OnCollisionEnter (Collision collisionInfo)
    {
       

        if (collisionInfo.collider.tag == "obsatacle") //yes i spelled it incorrectly
        {
            move.enabled = false;
            Time.timeScale = 0f;
            gameManager.gameover();
        }
        if (collisionInfo.collider.tag == "EBullet") 
        {
            move.enabled = false;
            Time.timeScale = 0f;
            gameManager.gameover();
        }

    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (transform.position.y < -1f)
        {
            move.enabled = false;
            Time.timeScale = 0f;
            gameManager.gameover();
        }
       
    }
}

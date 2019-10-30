using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	public float respawnHeight = -5;

	public float totalCoinAmount;

	//public float HorizontalSpeed;
	//public float VerticalSpeed;

	public Text countText;
	public Text winText;

	public GameObject ParticleSystem;
	public GameObject MainMenuBackBtn;

	public Joystick moveJoystick;
	
	private Rigidbody rb;

	Vector3 startPos;

	private int count;
	

	// Use this for initialization
	void Start () 
	{
		Spawn ();
		rb = GetComponent<Rigidbody>();
		startPos =  new Vector3 (0f, 0.5f, 0f);
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		if (moveJoystick.InputDirection != Vector3.zero) {
			movement = moveJoystick.InputDirection;
		}

		rb.AddForce (movement*speed);

		/*if(Mathf.Abs(Input.acceleration.x) > 0.1f || Mathf.Abs(Input.acceleration.x) < 0.1f ||
		   Mathf.Abs(Input.acceleration.z) > 0.1f || Mathf.Abs(Input.acceleration.z) < 0.1f)
		{ 
			moveHorizontal = Input.acceleration.x;
			moveVertical = Input.acceleration.z;
			movement = new Vector3 (moveHorizontal*HorizontalSpeed, 0, moveVertical*-1f*VerticalSpeed);
			rb.AddForce (movement*speed);
		}*/
	 
		//Respawn Code
		if (transform.position.y < respawnHeight) 
		{
			rb.isKinematic = true;
			Spawn();
			rb.isKinematic = false;
		} 

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}

		if (other.gameObject.CompareTag ("Special")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			Object.Instantiate(ParticleSystem, gameObject.transform.position, Quaternion.identity);
		}
	}

	void Spawn ()
	{
		transform.position = startPos;
	}

	void SetCountText ()
	{
		countText.text = "Presents: " + count.ToString ();
		if (count >= totalCoinAmount)
		{
			winText.text = "You Win!";
			MainMenuBackBtn.SetActive (true);
		}
	}

}

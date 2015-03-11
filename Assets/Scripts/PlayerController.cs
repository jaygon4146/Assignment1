using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Get Input

	//Apply Input

	public Rigidbody rb;
	public float speed;
	private int count;

	void Start() {		
		rb = GetComponent <Rigidbody> ();
		count = 0;
	}

	void Update ()		//Called before rendereing a frame
	{
	}

	void FixedUpdate ()	//Called before applying physics
	{
		float moveHorz = Input.GetAxis ("Horizontal");
		float moveVert = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorz, 0.0f, moveVert);

		//rigidbody.AddForce (movement);
		rb.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		//Destroy (other.gameObject);
		if (other.gameObject.tag == "Pickup") 
		{
			other.gameObject.SetActive (false);
			count += 1;
			
		}
	}

}

















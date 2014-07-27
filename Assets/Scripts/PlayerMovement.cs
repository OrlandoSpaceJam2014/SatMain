using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float acceleration;
	public float playerThrust;
	public float playerSpeed;
	public float playerSideSpeed;
	public float maxSpeed;
	public float rotationSpeed;

	public bool forward;
	public bool reverse;
	public bool port;
	public bool starboard;
	public bool isActive;

	// Use this for initialization
	void Start () {
		forward = false;
		reverse = false;
		port = false;
		starboard = false;

		playerThrust = 5.0f;
		playerSpeed = 0.0f;
		playerSideSpeed = 0.0f;
		maxSpeed = 50.0f;
		acceleration = (playerThrust * 50) * Time.deltaTime;
		rotationSpeed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("DPadVert") > 0.9)
			ForwardThrust ();
		else if (Input.GetAxis ("DPadVert") < -0.9)
			ReverseThrust ();

		if (Input.GetAxis ("DPadHort") < 0)
			PortThrust ();
		else if (Input.GetAxis("DPadHort") > 0)		
		    StarboardThrust ();

		if (Input.GetAxis ("RStickHort") > 0)
			this.transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime);
		else if (Input.GetAxis ("RStickHort") < 0)
			this.transform.Rotate (Vector3.down * rotationSpeed * Time.deltaTime);

		if (Input.GetAxis ("RStickVert") > 0 )
			this.transform.Rotate (Vector3.right * rotationSpeed * Time.deltaTime);
		else if (Input.GetAxis ("RStickVert") < 0)
			this.transform.Rotate (Vector3.left * rotationSpeed * Time.deltaTime);

		if(Input.GetAxis("LStickVert") > 0 || Input.GetAxis("LStickHort") > 0)
		{
			this.transform.Rotate(Vector3.back * rotationSpeed * 2f * Time.deltaTime);
		}
		else if( Input.GetAxis("LStickVert") < 0 || Input.GetAxis("LStickHort") < 0)
		{
			this.transform.Rotate(Vector3.forward * rotationSpeed * 2f *  Time.deltaTime);
		}
	
	}

	void ForwardThrust(){
		rigidbody.AddRelativeForce (Vector3.forward * acceleration);
		playerSpeed += 1.0f * Time.deltaTime;
		if (Input.GetAxis ("DPadVert") > 0.0 && Input.GetAxis ("DPadVert") < 0.1)
			isActive = false;
		else
			isActive = true;
	}

	void ReverseThrust(){
		rigidbody.AddRelativeForce (Vector3.back * acceleration);
		playerSpeed -= 1.0f * Time.deltaTime;
		if (Input.GetAxis ("DPadVert") < 0.0 && Input.GetAxis ("DPadVert") > -0.1)
			isActive = false;
		else
			isActive = true;
	}

	void PortThrust(){
		rigidbody.AddRelativeForce (Vector3.left * acceleration);
		playerSideSpeed += 1.0f * Time.deltaTime;
		if (Input.GetAxis ("DPadHort") < 0.0 && Input.GetAxis ("DPadHort") > -0.1)
			isActive = false;
		else
			isActive = true;
	}

	void StarboardThrust(){
		rigidbody.AddRelativeForce (Vector3.right * acceleration);
		playerSideSpeed -= 1.0f * Time.deltaTime;
		if (Input.GetAxis ("DPadHort") > 0.0 && Input.GetAxis ("DPadHort") < 0.1)
			isActive = false;
		else
			isActive = true;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.name == "Skybox")
		{
			//GameManager.Instance.m_bIsDead = true;
		}
	}

}

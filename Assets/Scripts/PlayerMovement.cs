using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float acceleration;
	public float playerThrust;
	public float rotationSpeed;
	public float maxThrust;
	public float naturalDrift;

	public bool forward;
	public bool reverse;
	public bool port;
	public bool starboard;

	// Use this for initialization
	void Start () {
		forward = false;
		reverse = false;
		port = false;
		starboard = false;

		playerThrust = 5;
		acceleration = (playerThrust * 50) * Time.deltaTime;
		rotationSpeed = 5;
		naturalDrift = 1;
		maxThrust = 50;
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
	}

	void ReverseThrust(){
		if (playerThrust < maxThrust)
			rigidbody.AddRelativeForce (Vector3.back * acceleration);
		else
			rigidbody.AddForce (Vector3.back);
	}

	void PortThrust(){
		if (playerThrust < maxThrust)
			rigidbody.AddRelativeForce (Vector3.left * acceleration);
		else
			rigidbody.AddForce (Vector3.left);
	}

	void StarboardThrust(){
		if (playerThrust < maxThrust)
			rigidbody.AddRelativeForce (Vector3.right * acceleration);
		else
			rigidbody.AddForce (Vector3.right);
	}

}

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
		rotationSpeed = 50;
		naturalDrift = 1;
		maxThrust = 50;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("DPadVert") > 0 || Input.GetKeyDown (KeyCode.W))
			ForwardThrust ();
		else if (Input.GetAxis ("DPadVert") < 0)
			ReverseThrust ();

		if (Input.GetAxis ("DPadHort") > 0)
			PortThrust ();
		else if (Input.GetAxis("DPadHort") < 0)		
		    StarboardThrust ();
	}

	void ForwardThrust(){
		if (playerThrust < maxThrust)
			rigidbody.AddRelativeForce (Vector3.forward * 50);
		else
			rigidbody.AddForce (Vector3.forward);
	}

	void ReverseThrust(){
		if (playerThrust < maxThrust)
			rigidbody.AddRelativeForce (Vector3.back * 50);
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

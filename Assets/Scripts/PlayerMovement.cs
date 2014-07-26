using UnityEngine;
using System.Collections;
using GamepadInput;

public class PlayerMovement : MonoBehaviour {
	
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

		rotationSpeed = 50;
		naturalDrift = 1;
		maxThrust = 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W)) {
			ForwardThrust ();
		}
		if (Input.GetKeyDown(KeyCode.S)) {
			ReverseThrust ();
		}
		if (Input.GetKeyDown(KeyCode.A)) {
			PortThrust ();
		}
		if (Input.GetKeyDown(KeyCode.D)) {
			StarboardThrust ();
		}
		/*transform.Rotate (GamePad.Axis.RightStick, 
		                 GamePad.Axis.RightStick, 0);*/
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
			rigidbody.AddRelativeForce (Vector3.left * 50);
		else
			rigidbody.AddForce (Vector3.left);
	}

	void StarboardThrust(){
		if (playerThrust < maxThrust)
			rigidbody.AddRelativeForce (Vector3.right * 50);
		else
			rigidbody.AddForce (Vector3.right);
	}
}

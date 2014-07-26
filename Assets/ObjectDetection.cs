using UnityEngine;
using System.Collections;

public class ObjectDetection : MonoBehaviour {

	public bool detection;
	public bool carryObject;

	public Ray detectRay;
	public RaycastHit hitInfo;

	public float rayLength = 500.0f;


	// Use this for initialization
	void Start () {
		detection = false;
		carryObject = false;

		detectRay = new Ray (transform.position, transform.forward);
	}
	
	// Update is called once per frame
	void Update () {

		Debug.DrawRay (detectRay.origin, detectRay.direction * rayLength);

		if (Physics.Raycast (detectRay.origin, detectRay.direction, out hitInfo, rayLength, 0)) {
			if(hitInfo.collider.tag == "Grabable" && Input.GetButtonDown("button 0")){
				GrabObject();
			}
			detection = true;
			Debug.Log ("We hit something!");
		}
		else
			detection = false;
	}

	void GrabObject(){
		carryObject = true;
	}
}

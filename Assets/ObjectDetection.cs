using UnityEngine;
using System.Collections;

public class ObjectDetection : MonoBehaviour {

	public bool detection;
	public bool carryObject;

	public Ray detectRay;
	public RaycastHit hitInfo;
	public GameObject objectScript;

	public float rayLength = 500.0f;
	private GrabObjectScript gbScript1;
	private GrabObjectScript gbScript2;
	private GrabObjectScript gbScript3;

	// Use this for initialization
	void Start () {
		detection = false;
		carryObject = false;
		gbScript1 = GameObject.Find("Dish").GetComponent<GrabObjectScript> ();
		gbScript2 = GameObject.Find("Panel").GetComponent<GrabObjectScript> ();
		gbScript3 = GameObject.Find("Power").GetComponent<GrabObjectScript> ();
		detectRay = new Ray (transform.position, transform.forward);
	}
	
	// Update is called once per frame
	void Update () {

		Debug.DrawRay (detectRay.origin, detectRay.direction * rayLength);

		if (Physics.Raycast (detectRay.origin, detectRay.direction, out hitInfo, rayLength, 0)) {
			if(hitInfo.collider.tag == "Grabable" && Input.GetButtonDown("button 0")){
				if(hitInfo.transform.gameObject.name == "Dish")
					gbScript1.isGrabbed = true;
				else if(hitInfo.transform.gameObject.name == "Panel")
					gbScript1.isGrabbed = true;
				else if(hitInfo.transform.gameObject.name == "Power")
					gbScript3.isGrabbed = true;


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

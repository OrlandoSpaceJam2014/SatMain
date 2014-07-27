using UnityEngine;
using System.Collections;

public class GrabObjectScript : MonoBehaviour {

	public static GrabObjectScript Instance;
	
	public GameObject playerGrabber;
	public bool isGrabbed;

	void Awake(){
		Instance = this;

		playerGrabber = GameObject.Find ("GrappleDetector");
	}

	void Start(){
		isGrabbed = false;
	}

	// Update is called once per frame
	void Update () {

		if(isGrabbed){
			this.transform.position = playerGrabber.transform.position;
			this.transform.rotation = playerGrabber.transform.rotation;
		}
	}
}

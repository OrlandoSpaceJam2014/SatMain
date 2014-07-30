using UnityEngine;
using System.Collections;

public class GrabObjectScript : MonoBehaviour {

	public static GrabObjectScript Instance;

	public bool isGrabbed;

	private GameObject playerGrabber;
	private GameObject ObjectTowPosition;

	void Awake()
	{
		Instance = this;
		playerGrabber = GameObject.Find ("Position");

	}

	void Start(){
		isGrabbed = false;
	}

	// Update is called once per frame
	void Update () 
	{

		if(isGrabbed)
		{
	
			this.transform.parent = playerGrabber.transform;
			this.transform.position = playerGrabber.transform.position;
		}
	}
}

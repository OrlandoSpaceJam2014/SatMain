using UnityEngine;
using System.Collections;

public class ObjectDetection : MonoBehaviour {


	public GameObject dish;
	public GameObject panel;
	public GameObject power;

	public GrabObjectScript dishScript;
	public GrabObjectScript panelScript;
	public GrabObjectScript powerScript;


	// Use this for initialization
	void Start () {
		dish = GameObject.Find ("Dish");
		panel = GameObject.Find ("Panel");
		power = GameObject.Find ("Power");

		dishScript = dish.GetComponent<GrabObjectScript> ();
		panelScript = panel.GetComponent<GrabObjectScript> ();
		powerScript = power.GetComponent<GrabObjectScript> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Dish") {
			Debug.Log ("Ran into the Dish");
			dishScript.isGrabbed = true;
		} 
		else if (other.name == "Panel") {
			Debug.Log ("Ran into the Panel");
			panelScript.isGrabbed = true;
		}
		else if (other.name == "Power") {
			Debug.Log ("Ran into the Power");
			powerScript.isGrabbed = true;
		}
	}
}

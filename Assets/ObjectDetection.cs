using UnityEngine;
using System.Collections;

public class ObjectDetection : MonoBehaviour {


	private GameObject dish;
	private GameObject panel;
	private GameObject power;

	// Use this for initialization
	void Start () {
		dish = GameObject.Find ("Dish");
		panel = GameObject.Find ("Panel");
		power = GameObject.Find ("Power");


	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Dish")
			Debug.Log ("Ran into the Dish");
		else if (other.name == "Panel")
			Debug.Log ("Ran into the Panel");
		else if (other.name == "Power")
			Debug.Log ("Ran into the Power");
	}
}

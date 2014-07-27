using UnityEngine;
using System.Collections;

public class GrabObjectScript : MonoBehaviour {

	public static GrabObjectScript Instance;

	public GameObject player;
	public bool isGrabbed;

	void Awake(){
		Instance = this;
	}

	void Start(){
		isGrabbed = false;
	}

	// Update is called once per frame
	void Update () {

		if(isGrabbed){
			this.transform.Translate(player.transform.position.x, player.transform.position.y, player.transform.position.z + 10);
		}
	}
}

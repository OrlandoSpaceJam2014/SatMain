using UnityEngine;
using System.Collections;

public class DialNeedleScript : MonoBehaviour {

	public float dialStartloc;
	public float dialCurloc;
	public float dialEndloc;
	public float changeRate;

	// Use this for initialization
	void Start () {
		dialCurloc = gameObject.transform.rotation.y;
		dialStartloc = 75.0f;
		dialEndloc = 285.0f;
		changeRate = 50;

		//Start the dial's current location at the dial's starting position.
		dialCurloc = dialStartloc;
	}
	
	// Update is called once per frame
	void Update () {
		print (this.transform.localEulerAngles.y);
		if (this.transform.localEulerAngles.y < dialEndloc) {
			transform.Rotate (Vector3.up * -changeRate * Time.deltaTime);
			dialStartloc = gameObject.transform.rotation.y;
		}
				
	}
}

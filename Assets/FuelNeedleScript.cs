using UnityEngine;
using System.Collections;

public class FuelNeedleScript : MonoBehaviour {
	
	public float dialStartloc;
	public float dialCurloc;
	public float dialEndloc;
	public float changeRate;
	private bool isEmpty = false;

	public GameObject player;
	public PlayerMovement thrusters;

	/*public float usageRate;
	public bool  isMoving = false;*/

	// Use this for initialization
	void Start () {
		dialCurloc = gameObject.transform.rotation.y;
		dialStartloc = 89.0f;
		dialEndloc = 266.0f;
		changeRate = 0;
		//usageRate = 0f;
		
		//Start the dial's current location at the dial's starting position.
		dialCurloc = dialStartloc;

		player = GameObject.Find ("Player");
		thrusters = player.GetComponent <PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (thrusters.isActive)
			changeRate = 5;
		else
			changeRate = 0;

		if (this.transform.localEulerAngles.y < dialEndloc + 3.0f &&
		    this.transform.localEulerAngles.y > dialEndloc - 3.0f) {
			isEmpty = true;
		}
		
		if(!isEmpty)
		{	
			transform.Rotate (Vector3.up * -changeRate * Time.deltaTime);
		}
		else
		{
			GameManager.Instance.m_bIsDead = true;
		}
		
		/*if(!isEmpty && isMoving)
		{
			usageRate = Random.Range(0,1);
			if(this.transform.localEulerAngles.y > dialStartloc)
			{
				this.transform.Rotate(Vector3.up * usageRate * Time.deltaTime);
			}
			else
			{
				// end game here // 
			}
		}*/
		
		
	}
}
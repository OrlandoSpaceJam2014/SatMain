using UnityEngine;
using System.Collections;

public class DialNeedleScript : MonoBehaviour {

	public float dialStartloc;
	public float dialCurloc;
	public float dialEndloc;
	public float changeRate;
	public float usageRate;
	public bool  isMoving = false;
	private bool isFull = false;
	
	// Use this for initialization
	void Start () {
		dialCurloc = gameObject.transform.rotation.y;
		dialStartloc = 290f;
		dialEndloc = 85.0f;
		changeRate = 50;
		usageRate = 0f;
		
		//Start the dial's current location at the dial's starting position.
		dialCurloc = dialEndloc;
	}
	
	// Update is called once per frame
	void Update () 
	{
			
		if(!isFull)
		{	
			if (this.transform.localEulerAngles.y > dialEndloc) 
			{
				transform.Rotate (Vector3.up * changeRate * Time.deltaTime);
				dialStartloc = gameObject.transform.rotation.y;
			}
			else
			{
				isFull = true;
			}
		}
		
		if(isFull && isMoving)
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
		}
		
				
	}
}

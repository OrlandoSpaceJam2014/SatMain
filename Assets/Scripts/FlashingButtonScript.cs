using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class FlashingButtonScript : MonoBehaviour {

	private Color  green;
	private Color 	red ; 
	
	private float  timer = 0f;
	private float  time = 0f; 
	private bool  getTimer = true;
	private bool  isRed = true;
	// Use this for initialization
	void Start () {
		green = new Color(33,234,42,255);
		red  = new Color(255,0,0,255);
	}
	
	// Update is called once per frame
	void Update ()
	{
	  if(time >timer)
	  {
	  	if(isRed)
	  	{
	  		this.renderer.material.color = Color.green;
	  		time = 0;
	  		isRed = false;
	  		getTimer = true;
	  	}
	  	else
	  	{
	  		this.renderer.material.color = red;
	  		time = 0;
	  		isRed = true;
	  		getTimer = true;
	  	}
	  }
	  else
	  {
	  	time += Time.deltaTime;
	  }
	  
	  if(getTimer)
	  {
	  	getTimer = false;
	  	timer = Random.Range(1,3);
	  }
	}
}

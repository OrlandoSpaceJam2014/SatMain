using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour 
{

	private RaycastHit 	m_rcHit;			// collects info that the raycast hits.
	private Ray 		m_rRay;				// ray for shooting in screen place on touch

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))  // if get mouse down or touch count != 0 same call 
		{
			m_rRay = Camera.main.ScreenPointToRay(Input.mousePosition); // set the ray at that position to world space
			if(Physics.Raycast(m_rRay,out m_rcHit)) 	// if it hit something collect that data
			{
				HitReturn(m_rcHit.transform.name);      // call to switch collected data with response
			}
		}
	}

	private void HitReturn(string hitName)
	{
		if(hitName == "Start")  
		{
				Application.LoadLevel(1);			
		}		
	}
}

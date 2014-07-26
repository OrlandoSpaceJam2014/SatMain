using UnityEngine;
using System.Collections;

public class SatScript : MonoBehaviour 
{
	private float 		m_fRotSpeed = 3.0f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		RotateObject();
	}
	
	void RotateObject()
	{
		this.transform.Rotate(Vector3.right * m_fRotSpeed * Time.deltaTime);
		this.transform.Rotate(Vector3.up * m_fRotSpeed * Time.deltaTime);
		this.transform.Rotate(Vector3.forward * m_fRotSpeed * Time.deltaTime);
	}
}

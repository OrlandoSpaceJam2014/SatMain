using UnityEngine;
using System.Collections;

public class SatScript : MonoBehaviour 
{
	
	private float 		m_fRotSpeed = 2.0f;
	private bool []     m_bIsAttaced;
	
	public GameObject[]	m_goPartsPorts;
	public float 		m_fSatHealth = 100.0f;
	
	
	// Use this for initialization
	void Start () 
	{
		m_bIsAttaced = new bool[3];
		for (int i = 0; i < m_bIsAttaced.Length; i++)
		 {
			m_bIsAttaced[i] = false;	
		 }
	}
	
	// Update is called once per frame
	void Update ()
	{
		RotateObject();
		
		
		if(m_fSatHealth <= 0)
		{
			// end game here//
		}
	}
	
	void RotateObject()
	{
		this.transform.Rotate(Vector3.right * m_fRotSpeed * Time.deltaTime);
		this.transform.Rotate(Vector3.up * m_fRotSpeed * Time.deltaTime);
		this.transform.Rotate(Vector3.forward * m_fRotSpeed * Time.deltaTime);
	}
}

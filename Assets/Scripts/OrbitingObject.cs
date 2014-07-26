using UnityEngine;
using System.Collections;

public class OrbitingObject : MonoBehaviour
 {
 	private GameObject		m_goTargetObject;
 	private float 			m_fRotSpeed = 6.0f;
 	private float 			m_fMoveSpeed = 3.0f;


	void Awake()
	{
		m_goTargetObject = GameObject.FindGameObjectWithTag("Player");
	}
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
 	
 	void MoveObject()
 	{
 		
 	}
}

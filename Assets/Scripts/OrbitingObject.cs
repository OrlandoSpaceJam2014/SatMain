using UnityEngine;
using System.Collections;

public class OrbitingObject : MonoBehaviour
 {
 	private GameObject		m_goTargetObject;
 	
 	private Vector3			m_v3NewMove;
 	
 	private float 			m_fRotSpeed = 6.0f;
 	private float 			m_fMoveSpeed = 0.01f;
 	private float 			m_fRadius = 1000f;
	private float 			m_fCurrentDistance = 0f;
	
	private bool			m_bSwitchDirection = false;

	void Awake()
	{
		m_goTargetObject = GameObject.FindGameObjectWithTag("Sat");
	}
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		RotateObject();
		MoveObject();
		CheckDistance();
		
		
		
		
		
		
		if(m_bSwitchDirection)
		{
			if(m_fMoveSpeed < 0)
				m_fMoveSpeed = .01f;
			else
				m_fMoveSpeed = -.01f;
				m_bSwitchDirection = false;
		}
	}
 	
 	void CheckDistance()
 	{
 		m_fCurrentDistance = Vector3.Distance(this.transform.position, m_goTargetObject.transform.position);
 		if(m_fCurrentDistance > m_fRadius)
 		{
 			m_bSwitchDirection= true;
 		}
 	}
 	
 	void RotateObject()
 	{
		this.transform.Rotate(Vector3.right * m_fRotSpeed * Time.deltaTime);
		this.transform.Rotate(Vector3.up * m_fRotSpeed * Time.deltaTime);
		this.transform.Rotate(Vector3.forward * m_fRotSpeed * Time.deltaTime);
		
 	}
 	
 	void MoveObject()
 	{
 		m_v3NewMove.x = this.transform.position.x * m_fMoveSpeed * Time.deltaTime;
		m_v3NewMove.y = this.transform.position.y * m_fMoveSpeed * Time.deltaTime;
		m_v3NewMove.z = this.transform.position.z * m_fMoveSpeed * Time.deltaTime;
		
		this.transform.position += m_v3NewMove;
		
	}
}

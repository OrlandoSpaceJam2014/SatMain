using UnityEngine;
using System.Collections;

public class PowerSupplyScript : MonoBehaviour
{

	public GameObject 		m_goHiddenObject;
	public GameObject		m_goParticle;
	private bool 	  		m_bIsAttached = false;
	
	private GameManager 	m_cGameManager;
	
	// Use this for initialization
	void Start () 
	{
		m_cGameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(m_bIsAttached)
		{
			for (int i = 0; i < 3; i++) {
				if(!m_cGameManager.Checkpoints[i])
					m_cGameManager.Checkpoints[i] = true;
			}
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		
		if(other.name == "Power")
		{
			m_bIsAttached = true;
			DestroyObject(other.gameObject);
			DestroyObject(m_goParticle.gameObject);
			m_goHiddenObject.SetActive(true);
		}
	}
}

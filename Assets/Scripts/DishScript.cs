using UnityEngine;
using System.Collections;

public class DishScript : MonoBehaviour
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
		
			m_cGameManager.Checkpoints[0] = true;
		}
	}

	void OnTriggerEnter(Collider other)
	{

		if(other.name == "Dish")
		{
			m_bIsAttached = true;
			DestroyObject(other.gameObject);
			DestroyObject(m_goParticle.gameObject);
			m_goHiddenObject.SetActive(true);
		}
	}
}

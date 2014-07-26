using UnityEngine;
using System.Collections;

public class PlayerSettingsScript: MonoBehaviour
{
	public PlayerSettingsScript	Instance;
	public bool				m_bOculusOn = false;
	public float 			m_SFXVolume = 1.0f;
	public float 			m_bgnMusic = 1.0f;

	private GameObject		m_goMainCamera;
	private GameObject		m_goOculusCamera;


	void Awake()
	{
		Instance = this;
		DontDestroyOnLoad(transform.gameObject);
	}

	void Start ()
	{
		m_goMainCamera = GameObject.FindGameObjectWithTag("MainCamera");
		m_goOculusCamera = GameObject.FindGameObjectWithTag("OculusCamera");

		if(m_bOculusOn)
		{

			m_goOculusCamera.SetActive(true);
			m_goMainCamera.SetActive(false);

		}
		else
		{
			m_goMainCamera.SetActive(true);
			m_goOculusCamera.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

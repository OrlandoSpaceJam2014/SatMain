	using UnityEngine;
using System.Collections;

public class PlayerSettingsScript: MonoBehaviour
{
	public static PlayerSettingsScript	Instance;
	public bool				m_bOculusOn = false;
	public float 			m_SFXVolume = 1.0f;
	public float 			m_bgnMusic = 1.0f;
	public bool 			m_bUwin = false;
	public bool 			m_bGameOver = false;
	public GameObject		m_goMainCamera;
	public GameObject		m_goOculusCamera;
	private bool 			m_bFirstPass = false;

	void Awake()
	{
		Instance = this;
		DontDestroyOnLoad(transform.gameObject);
	}

	void Start ()
	{
	

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(m_goMainCamera == null || m_goOculusCamera == null)
		{
			m_goMainCamera = GameObject.FindGameObjectWithTag("MainCamera");
			m_goOculusCamera = GameObject.FindGameObjectWithTag("OculusCamera");
		}
		if(!m_bFirstPass)
		{

			if(!OVRDevice.IsHMDPresent() || !OVRDevice.IsSensorPresent())
			{
				m_bOculusOn= false;
			}
			else
			{
				m_bOculusOn = true;
			}
			m_bFirstPass = true;
		}

		if(Input.GetKeyDown(KeyCode.O))
		{
			if(m_bOculusOn)
			{
				m_bOculusOn= false;
			}
			else 
			{
				m_bOculusOn = true;
			}
		}

		if(m_bOculusOn)
		{
			m_goMainCamera.SetActive(false);
			m_goOculusCamera.SetActive(true);
		}
		else
		{
			m_goMainCamera.SetActive(true);
			m_goOculusCamera.SetActive(false);	
		}
		if(m_bGameOver && Application.loadedLevel == 2)
		{
			// telll final menu what to do 
			
		}
		
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}
	}
}

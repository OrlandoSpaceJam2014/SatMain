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
		print (OVRDevice.IsHMDPresent().ToString());
		if(OVRDevice.IsHMDPresent())
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

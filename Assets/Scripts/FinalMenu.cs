using UnityEngine;
using System.Collections;

public class FinalMenu : MonoBehaviour 
{
	
	public static FinalMenu Instance ;
	
	public GameObject titlePlane;
	
	public bool  m_bUWin = false;
	public Texture[] finalMenu;
	private float timer = 5.0f;
	private float time = 0.0f;
	
	// Use this for initialization
	void Start () 
	{
		m_bUWin = PlayerSettingsScript.Instance.m_bUwin;
		if(m_bUWin)
		{
			titlePlane.renderer.material.mainTexture = finalMenu[0];
		}
		else
		{
			titlePlane.renderer.material.mainTexture = finalMenu[1];
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(timer > time)
		{
			time += Time.deltaTime;
		}
		else
		{
			Application.LoadLevel(0);
		}
	}
}

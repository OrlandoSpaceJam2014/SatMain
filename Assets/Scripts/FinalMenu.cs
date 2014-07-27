using UnityEngine;
using System.Collections;

public class FinalMenu : MonoBehaviour 
{
	
	public static FinalMenu Instance ;
	public GameObject plane;
	
	public bool  m_bUWin = false;
	
	// Use this for initialization
	void Start () 
	{
		m_bUWin = PlayerSettingsScript.Instance.m_bUwin;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

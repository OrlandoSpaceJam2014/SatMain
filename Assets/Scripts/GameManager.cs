using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager Instance ;

	public bool []			  Checkpoints;
	public bool				  m_bIsDead = false;
	public int 				  m_nIncrementer;
	// Use this for initialization
	
	void Awake()
	{
		Instance = this;
	}
	void Start ()
	{	
		Checkpoints = new bool[3];
		for (int i = 0; i < 3; i++) 
		{
			Checkpoints[i] = false;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

		CheckObjectives();


		if(m_bIsDead)
		{
			PlayerSettingsScript.Instance.m_bGameOver = true;
			PlayerSettingsScript.Instance.m_bUwin = false;
			Application.LoadLevel(2);
		}
	}
	
	void CheckObjectives()
	{
		for ( ;m_nIncrementer < 3;) 
		{
			if(!Checkpoints[m_nIncrementer])
			{
				return;
			}
			else 
			{
				m_nIncrementer++;
			}
		}
		if( m_nIncrementer == 3)
		{
			PlayerSettingsScript.Instance.m_bGameOver = true;
			PlayerSettingsScript.Instance.m_bUwin = true;
			StartCoroutine("PauseForTheEnd", 5);
		}
	}

	private IEnumerator PauseForTheEnd(float time)
	{
		yield return new WaitForSeconds(time);
		Application.LoadLevel(2);
	}
}

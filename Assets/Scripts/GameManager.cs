using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager Instance ;

	public bool []			  Checkpoints;

	public bool				  m_bIsDead = false;
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

		for (int i = 0; i < 3; i++) 
		{
			if(!Checkpoints[i])
			{
				return;
			}
			else if( i == 3)
			{
				//end the game	you won.
			}
		}


		if(m_bIsDead)
		{
			// end the game u died;
		}
	}
}

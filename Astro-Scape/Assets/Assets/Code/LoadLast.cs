using UnityEngine;
using System.Collections;

public class LoadLast : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		LevelManager.getLastLevel ();
	}
	
	// Update is called once per frame
	public void onClick ()
	{
		//LevelManager.getLastLevel ();
		LevelManager.changeToPreviousLvl ();
	
	}
}

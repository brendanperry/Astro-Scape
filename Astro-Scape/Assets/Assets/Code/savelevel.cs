using UnityEngine;
using System.Collections;

public class savelevel : MonoBehaviour
{

	void Awake ()
	{
		
		LevelManager.setLastLevel (Application.loadedLevelName);
	}
}

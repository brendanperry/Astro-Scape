using UnityEngine;
using System.Collections;

public class leave : MonoBehaviour
{



	public void onClick ()
	{

		LevelManager.setLastLevel (Application.loadedLevelName);
	}
}

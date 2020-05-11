using UnityEngine;
using System.Collections;

public class donotKill : MonoBehaviour {

	//static bool AudioBegin = false; 
	
	void Awake()
	{
		DontDestroyOnLoad (gameObject);
	}

//		if (!AudioBegin) {
//			GetComponent<AudioSource>().Play ();
//			DontDestroyOnLoad (gameObject);
//			AudioBegin = true;
//		} 
//	}
	
	void Update () {
		if(Application.loadedLevelName == "AstroGame")
		{
			Destroy (this.gameObject);
		}
		
	}
}

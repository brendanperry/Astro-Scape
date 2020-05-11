using UnityEngine;
using System.Collections;

public class checkaudio : MonoBehaviour
{
	int optCheck;

	// Use this for initialization
	void Start ()
	{
		optCheck = PlayerPrefs.GetInt ("OptCheck", 1);

		if (optCheck == 1) {

			PlayerPrefsX.SetBool ("mute", true);
			PlayerPrefsX.SetBool ("toggle", true);
			PlayerPrefsX.SetBool ("vibrate", true);
			PlayerPrefsX.SetBool ("revive", true);

			PlayerPrefs.SetInt ("OptCheck", 2);
		}

		if (PlayerPrefsX.GetBool ("mute") == true) {

			AudioListener.pause = false;
		} else {
			AudioListener.pause = true;
		}

	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

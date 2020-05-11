using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{

	public bool mute;
	public Toggle togl;

	void Awake ()
	{
		
		if (PlayerPrefsX.GetBool ("mute", true)) {
			
			togl.isOn = true;
			mute = false;
		} else {
			
			togl.isOn = false;
			mute = true;
		}
	}

	
	public void OnToggleChanged ()
	{
		
		mute = !mute;
		
	}

	void Update ()
	{
		
		if (mute == true) {
			
			PlayerPrefsX.SetBool ("mute", false);
			AudioListener.pause = true;
		}
		
		if (mute == false) {
			
			PlayerPrefsX.SetBool ("mute", true);
			AudioListener.pause = false;
		}
	}
}
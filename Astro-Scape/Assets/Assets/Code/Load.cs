using UnityEngine;
using System.Collections;
//using Prime31;

public class Load : MonoBehaviour
{
	public string scene;
	public string scene2;
	// Use this for initialization

	//public int scenetoload;

	void Awake ()
	{
		

	}

	void Start ()
	{
		

		Invoke ("ChangeScene", 2);

		if (PlayerPrefsX.GetBool ("SaveDate", true)) {

			TimeMaster.instance.SaveDate ();
			PlayerPrefsX.SetBool ("SaveDate", false);
		}
	
	}
	
	// Update is called once per frame
	void ChangeScene ()
	{
		Application.LoadLevel (scene);
	}	
}

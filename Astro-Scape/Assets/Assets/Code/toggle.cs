using UnityEngine;
using System.Collections;

public class toggle : MonoBehaviour {

	public bool CameraOn = true;

	// Use this for initialization
	void Start () {

		CameraOn = true;
	
	}
	
	// Update is called once per frame
	public void changeBool () {


		CameraOn = false;

		Debug.Log ("Shake is off");

		PlayerPrefs.SetInt ("CameraOn", CameraOn ? 1 : 0);
	
	}
}

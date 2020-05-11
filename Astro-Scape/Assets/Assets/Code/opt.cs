using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class opt : MonoBehaviour {
	
	public Camera MainCamera;
	public Camera Camera2;
	public Camera Cam3;

	// Use this for initialization
	void Start () {
		
		MainCamera.enabled = true;
		Camera2.enabled = false;
	}
	
	// Update is called once per frame
	public void onClick (bool CameraChange) {
		
		
		MainCamera.enabled = false;
		Camera2.enabled = false;
		Cam3.enabled = true;


		GameObject xp = GameObject.Find ("Explosive Click");
		xp.GetComponent<xplodeClick>().xplode = false;

	}
}

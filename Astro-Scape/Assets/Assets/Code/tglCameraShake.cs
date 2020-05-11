using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tglCameraShake : MonoBehaviour {

	public int toggleState; 
	public bool CShake = true;
	public Toggle cOn;

	void Start () {
	
		CShake = true;
		toggleState = PlayerPrefs.GetInt ("toggleState", 1);


	}
	
	// Update is called once per frame
	public void OnTogglePushed () {

		CShake = !CShake;
	
		}

	void Update () {

		if (CShake == true) {
			PlayerPrefsX.SetBool ("CShake", true);
			PlayerPrefs.SetInt ("toggleState", 1);
		
		
		}

		if (CShake == false) {

			PlayerPrefsX.SetBool ("CShake", false);
			PlayerPrefs.SetInt ("toggleState", 0);
		}  
	}
}
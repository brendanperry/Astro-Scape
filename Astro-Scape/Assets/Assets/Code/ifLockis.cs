using UnityEngine;
using System.Collections;

public class ifLockis : MonoBehaviour {

	public GameObject helperLock;

	public string myBool;

	bool active;

	// Use this for initialization
	void Start () {

		active = PlayerPrefsX.GetBool (myBool);
	
	}
	
	// Update is called once per frame
	void Update () {

		if(active == false){

			gameObject.SetActive (false);
			helperLock.SetActive (false);

		}
		else
		{
			gameObject.SetActive (true);
			helperLock.SetActive (true);
		}


	
	}
}

using UnityEngine;
using System.Collections;
//using UnityEngine.Advertisements;
using UnityEngine.UI;

public class ifAdIsReady : MonoBehaviour {


	public Button button;
	public Text text;
	public Text text2;

	public bool IsReady = false;

	// Use this for initialization
	void Start () {

		button.enabled = false;
		text.enabled = false;
		text2.enabled = false;

		IsReady = false;
	
	}
	
	// Update is called once per frame
	void Update () {


		if (IsReady == true) {

			button.enabled = true;
			text.enabled = true;
			text2.enabled = true;
		}


	}
}

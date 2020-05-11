using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggleDis : MonoBehaviour
{
	public bool yourBoolHere;
	public bool toggle;
	public Toggle tgl;
	public string mrBool;


	void Awake ()
	{

		if (PlayerPrefsX.GetBool (mrBool, true)) {

			tgl.isOn = true;
		} else {

			tgl.isOn = false;
		}
	}


	public void OnToggleChanged ()
	{

		toggle = !toggle;

	}

	void Update ()
	{

		if (toggle == true) {

			PlayerPrefsX.SetBool (mrBool, false);

		}

		if (toggle == false) {

			PlayerPrefsX.SetBool (mrBool, true);

		}
	}
}
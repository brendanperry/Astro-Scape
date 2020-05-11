using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ships : MonoBehaviour
{

	public bool toggle;
	public Toggle tgl;

	public string custom;

	public GameObject check;


	void Awake ()
	{
		



	}

	void Start ()
	{
		if (PlayerPrefsX.GetBool (custom, true)) {

			tgl.isOn = true;
			check.SetActive (true);

		} else {

			tgl.isOn = false;
			check.SetActive (false);
		}
	}

	
	
	public void OnToggleChanged ()
	{
		
		toggle = !toggle;

		if (toggle == true) {

			PlayerPrefsX.SetBool (custom, true);
			check.SetActive (true);
			//tgl.interactable = false;
			//tgl.isOn = true;

		} else {

			PlayerPrefsX.SetBool (custom, false);
			check.SetActive (false);
			//tgl.interactable = true;
			//tgl.isOn = false;
		}

	}

	void Update ()
	{
		if (tgl.isOn == true) {

			check.SetActive (true);
			tgl.interactable = false;

		} else {

			check.SetActive (false);
			tgl.interactable = true;
		}

	}
}


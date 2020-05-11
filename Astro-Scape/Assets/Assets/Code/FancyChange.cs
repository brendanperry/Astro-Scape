using UnityEngine;
using System.Collections;

public class FancyChange : MonoBehaviour
{

	public int tut;

	void Start ()
	{

		tut = PlayerPrefs.GetInt ("tut", 1);
	}

	public void onClick ()
	{

		if (tut == 1) {

			PlayerPrefs.SetInt ("tut", 2);
			Application.LoadLevel ("Game Tut");
		} else {
			Application.LoadLevel ("AstroGame");
		}
	}
}
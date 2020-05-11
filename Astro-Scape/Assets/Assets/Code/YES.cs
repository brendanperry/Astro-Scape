using UnityEngine;
using System.Collections;

public class YES : MonoBehaviour
{

	public string ship;

	public GameObject yes;
	public GameObject no;
	public GameObject panel;
	public GameObject panel2;
	public GameObject txt;

	public GameObject sorry;

	public GameObject thisLock;

	int parts;

	void Update ()
	{
		parts = PlayerPrefs.GetInt ("shipParts");
	
	}

	public void onClick ()
	{
		if (parts >= 200) {
			
			PlayerPrefsX.SetBool (ship, false);

			parts -= 200;
			PlayerPrefs.SetInt ("shipParts", parts);

//			panel.SetActive (false);
//			panel2.SetActive (false);
			yes.SetActive (false);
			no.SetActive (false);
			txt.SetActive (false);
			StartCoroutine (showUnlock ());




		} else {
			sorry.SetActive (true);
			StartCoroutine (sorryplz ());
		}
	}

	IEnumerator showUnlock ()
	{
		

		yield return new WaitForSeconds (.5f);
		thisLock.SetActive (true);
		panel.SetActive (true);
		panel2.SetActive (true);
		yield return new WaitForSeconds (1.5f);

		thisLock.SetActive (false);
		panel.SetActive (false);
		panel2.SetActive (false);
	}

	IEnumerator sorryplz ()
	{

		yield return new WaitForSeconds (1.5f);
				
		sorry.SetActive (false);
	}
}



using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class isUnlocked : MonoBehaviour
{

	public string locked;
	public Button ship;
	public GameObject lockit;


	// Use this for initialization
	void Update ()
	{
		
	
		if (PlayerPrefsX.GetBool (locked) == false) {

			lockit.SetActive (false);
			ship.GetComponent<Button> ().interactable = true;
		} else {
			lockit.SetActive (true);
			ship.GetComponent<Button> ().interactable = false;
		}

	}
}

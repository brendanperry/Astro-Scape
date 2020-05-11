using UnityEngine;
using System.Collections;

public class revive : MonoBehaviour
{

	public int reviveCost;

	public int shipParts;

	public GameObject txt;

	public string scene;

	// Use this for initialization
	void Start ()
	{

		shipParts = PlayerPrefs.GetInt ("shipParts", shipParts);
	
	}
	
	// Update is called once per frame
	public void onClick ()
	{

		if (shipParts >= 10) {
			Debug.Log ("Transaction Confirmed");
			//shipParts = PlayerPrefs.GetInt ("shipParts");
			shipParts -= reviveCost;
			PlayerPrefs.SetInt ("shipParts", shipParts);

			Application.LoadLevel (scene);

			//Application.LoadLevel ("ShipSelect");
		} else {
			txt.SetActive (true);
		}

	}

	void Update ()
	{

		if (txt.activeInHierarchy == true) {

			StartCoroutine (offText ());
		}
	}

	IEnumerator offText ()
	{

		yield return new WaitForSeconds (2);
		txt.SetActive (false);
	}
}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Prime31;

public class spendParts : MonoBehaviour
{

	public int shipParts;

	//public int cost;

	public GameObject menu;

	public GameObject lelock;

	public string whatPart;
	public string save;

	public GameObject redLock;
	public GameObject littleRedLock;
	public Toggle redShip;

	public int GHunlocked;
	public string yourShipHere;
	public string AchievementName;
	public string allDone;

	private GameObject gc;

	public GameObject panel;
	public GameObject panel2;

	public GameObject yesButton;

	public int NUMBER;

	//	bool stuff;

	// Use this for initialization
	void Start ()
	{
		
		gc = GameObject.Find ("GameCenter MNGR");

		shipParts = PlayerPrefs.GetInt ("shipParts");
		if (shipParts < 0) {
			shipParts = 0;
		}
		lelock.SetActive (false);
		//GHunlock = PlayerPrefs.GetInt (yourShipHere);

	}
	
	// Update is called once per frame
	public void onClick ()
	{

		if (shipParts >= 50) {

			yesButton.GetComponent<Button> ().enabled = false;

			PlayerPrefsX.SetBool (save, true);

			shipParts -= 50;

			PlayerPrefs.SetInt ("shipParts", shipParts);


//			panel.SetActive (true);
//			panel2.SetActive (true);
			GHunlocked = PlayerPrefs.GetInt (yourShipHere);
			GHunlocked += 1;
			PlayerPrefs.SetInt (yourShipHere, GHunlocked);
			StartCoroutine ("lockGO");



			if (PlayerPrefs.GetInt (yourShipHere) >= 1) {
				//GameCenterBinding.reportAchievement ("FirstColor", 100);
				gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("firstcolor");

			}

			if (PlayerPrefs.GetInt (yourShipHere) == 10) {

				//GameCenterBinding.reportAchievement (AchievementName, 100);

				if (AchievementName == "maxhind") {
					gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("maxhind");
				} else if (AchievementName == "maxbird") {
					gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("maxthunder");
				} else if (AchievementName == "maxnaut") {
					gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("maxnaut");
				}


			}

			if (PlayerPrefsX.GetBool ("Golden") == true && PlayerPrefsX.GetBool ("Thunder") == true && PlayerPrefsX.GetBool ("Naut") == true) {

				//GameCenterBinding.reportAchievement ("unlockall", 100);
				gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("unlockall");

			}

		} else {

			StartCoroutine (NotEnough ());

		}
	
	}

	void Update ()
	{
		NUMBER = PlayerPrefs.GetInt (yourShipHere);
		shipParts = PlayerPrefs.GetInt ("shipParts");

		if (PlayerPrefsX.GetBool (save, true)) {

			redLock.SetActive (false);
			littleRedLock.SetActive (false);
			redShip.GetComponent<Toggle> ().enabled = true;

		} else {
			redLock.SetActive (true);
			littleRedLock.SetActive (true);
			redShip.GetComponent<Toggle> ().enabled = false;
		}

		if (redLock.activeInHierarchy == true && littleRedLock.activeInHierarchy == true) {
			
			redShip.isOn = false;
		}

	}

	IEnumerator lockGO ()
	{

		yield return new WaitForSeconds (.5f);
		menu.SetActive (false);
		lelock.SetActive (true);
		GameObject aud = GameObject.Find ("soundeffect");
		aud.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (1.5f);
		lelock.SetActive (false);
//		panel.SetActive (false);
//		panel2.SetActive (false);

	}

	IEnumerator NotEnough ()
	{

		GameObject fail = GameObject.Find ("Failtext");
		fail.GetComponent<Text> ().enabled = true;
		yield return new WaitForSeconds (2);
		fail.GetComponent<Text> ().enabled = false;
	}
}

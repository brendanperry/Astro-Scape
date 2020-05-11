using UnityEngine;
using System.Collections;
//using ChartboostSDK;

public class BOOLlistN : MonoBehaviour
{

	int number = 1;

	public bool normalFire;
	public bool redFire;
	public bool blueFire;
	public bool	yellowFire;
	public bool	greenFire;
	public bool pinkFire;

	public bool normalShip;
	public bool redShip;
	public bool blueShip;
	public bool yellowShip;
	public bool greenShip;
	public bool pinkShip;

	public GameObject Text;
	public GameObject Texts;

	public GameObject Panel;
	public GameObject Panl;

	public GameObject lelock;


	// Use this for initialization
	void Start ()
	{
		number = Random.Range (1, 11);

		redFire = PlayerPrefsX.GetBool ("TheRedFireN");
		blueFire = PlayerPrefsX.GetBool ("TheBlueFireN");
		yellowFire = PlayerPrefsX.GetBool ("TheYellowFireN");
		greenFire = PlayerPrefsX.GetBool ("TheGreenFireN");
		pinkFire = PlayerPrefsX.GetBool ("ThePinkFireN");

		redShip = PlayerPrefsX.GetBool ("TheRedShipN");
		blueShip = PlayerPrefsX.GetBool ("TheBlueShipN");
		yellowShip = PlayerPrefsX.GetBool ("TheYellowShipN");
		greenShip = PlayerPrefsX.GetBool ("TheGreenShipN");
		pinkShip = PlayerPrefsX.GetBool ("ThePinkShipN");

		Text.SetActive (false);
		Texts.SetActive (false);
		Panel.SetActive (false);
		Panl.SetActive (false);

	}

	public void onClick ()
	{
		StartCoroutine ("unlock");//turn off in build
        /*
		if (Chartboost.hasRewardedVideo (CBLocation.Default)) {

			Chartboost.showRewardedVideo (CBLocation.Default);
			StartCoroutine ("unlock");
		}*/
	}

	// Update is called once per frame
	public void unlock ()
	{
		if (number == 1) {

			Debug.Log ("1");

			if (redShip == false) {

				PlayerPrefsX.SetBool ("TheRedShipN", true);
				StartCoroutine ("lockGO");
			} 
			if (redShip == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 2) {

			Debug.Log ("2");

			if (blueShip == false) {

				PlayerPrefsX.SetBool ("TheBlueShipN", true);
				StartCoroutine ("lockGO");
			} 
			if (blueShip == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 3) {

			Debug.Log ("3");

			if (pinkShip == false) {

				PlayerPrefsX.SetBool ("ThePinkShipN", true);
				StartCoroutine ("lockGO");
			} 
			if (pinkShip == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 4) {

			Debug.Log ("4");

			if (yellowShip == false) {

				PlayerPrefsX.SetBool ("TheYellowShipN", true);
				StartCoroutine ("lockGO");
			} 
			if (yellowShip == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 5) {

			Debug.Log ("5");

			if (greenShip == false) {

				PlayerPrefsX.SetBool ("TheGreenShipN", true);
				StartCoroutine ("lockGO");
			} 
			if (greenShip == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 6) {

			Debug.Log ("6");

			if (greenFire == false) {

				PlayerPrefsX.SetBool ("TheGreenFireN", true);
				StartCoroutine ("lockGO");
			} 
			if (greenFire == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 7) {

			Debug.Log ("7");

			if (blueFire == false) {

				PlayerPrefsX.SetBool ("TheBlueFireN", true);
				StartCoroutine ("lockGO");
			} 
			if (blueFire == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 8) {

			Debug.Log ("8");

			if (redFire == false) {

				PlayerPrefsX.SetBool ("TheRedFireN", true);
				StartCoroutine ("lockGO");
			} 
			if (redFire == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 9) {

			Debug.Log ("9");

			if (yellowFire == false) {

				PlayerPrefsX.SetBool ("TheYellowFireN", true);
				StartCoroutine ("lockGO");
			} 
			if (yellowFire == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 10) {

			Debug.Log ("10");

			if (pinkFire == false) {

				PlayerPrefsX.SetBool ("ThePinkFireN", true);
				StartCoroutine ("lockGO");
			} 
			if (pinkFire == true) {

				Text.SetActive (true);
				Texts.SetActive (true);
				Panel.SetActive (true);
				Panl.SetActive (true);
			}

		} else if (number == 11) {

			Text.SetActive (true);
			Texts.SetActive (true);
			Panel.SetActive (true);
			Panl.SetActive (true);
		}
	}

	IEnumerator lockGO ()
	{

		yield return new WaitForSeconds (.5f);
		lelock.SetActive (true);
		yield return new WaitForSeconds (1.5f);
		lelock.SetActive (false);


	}
}
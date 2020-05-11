using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class first : MonoBehaviour
{

	bool LeFirst = true;

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

	// Use this for initialization
	void Start ()
	{


		if (LeFirst == true) {

			pinkFire = PlayerPrefsX.SetBool ("ThePinkFire", false);
			greenShip = PlayerPrefsX.SetBool ("TheGreenShip", false);
			yellowFire = PlayerPrefsX.SetBool ("TheYellowFire", false);
			yellowShip = PlayerPrefsX.SetBool ("TheYellowShip", false);
			redFire = PlayerPrefsX.SetBool ("TheRedFire", false);
			blueFire = PlayerPrefsX.SetBool ("TheBlueFire", false);
			pinkShip = PlayerPrefsX.SetBool ("ThePinkShip", false);
			greenFire = PlayerPrefsX.SetBool ("TheGreenFire", false);
			blueShip = PlayerPrefsX.SetBool ("TheBlueShip", false);
			redShip = PlayerPrefsX.SetBool ("TheRedShip", false);

			GameObject redS = GameObject.Find ("RedS");
			redS.GetComponent<Toggle> ().isOn = false;

			GameObject redF = GameObject.Find ("RedF");
			redF.GetComponent<Toggle> ().isOn = false;

			GameObject blueS = GameObject.Find ("BlueS");
			blueS.GetComponent<Toggle> ().isOn = false;

			GameObject blueF = GameObject.Find ("BlueF");
			blueF.GetComponent<Toggle> ().isOn = false;

			GameObject greenS = GameObject.Find ("GreenS");
			greenS.GetComponent<Toggle> ().isOn = false;

			GameObject greenF = GameObject.Find ("GreenF");
			greenF.GetComponent<Toggle> ().isOn = false;

			GameObject yellowS = GameObject.Find ("YellowS");
			yellowS.GetComponent<Toggle> ().isOn = false;

			GameObject yellowF = GameObject.Find ("YellowF");
			yellowF.GetComponent<Toggle> ().isOn = false;

			GameObject pinkS = GameObject.Find ("PinkS");
			pinkS.GetComponent<Toggle> ().isOn = false;

			GameObject pinkF = GameObject.Find ("PinkF");
			pinkF.GetComponent<Toggle> ().isOn = false;

			PlayerPrefsX.SetBool ("pinkFire", false);
			PlayerPrefsX.SetBool ("greenShip", false);
			PlayerPrefsX.SetBool ("yellowFire", false);
			PlayerPrefsX.SetBool ("yellowShip", false);
			PlayerPrefsX.SetBool ("redShip", false);
			PlayerPrefsX.SetBool ("blueFire", false);
			PlayerPrefsX.SetBool ("pinkShip", false);
			PlayerPrefsX.SetBool ("greenFire", false);
			PlayerPrefsX.SetBool ("blueShip", false);
			PlayerPrefsX.SetBool ("redShip", false);

			

			LeFirst = false;

		}
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

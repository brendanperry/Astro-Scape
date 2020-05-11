using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Nbools : MonoBehaviour
{


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

	public Toggle normalS;
	public Toggle normalF;




	public GameObject check;



	int parts;

	// Use this for initialization
	void Start ()
	{

		if (PlayerPrefsX.GetBool ("rasberry", true)) {

			pinkFire = PlayerPrefsX.SetBool ("ThePinkFireN", false);
			greenShip = PlayerPrefsX.SetBool ("TheGreenShipN", false);
			yellowFire = PlayerPrefsX.SetBool ("TheYellowFireN", false);
			yellowShip = PlayerPrefsX.SetBool ("TheYellowShipN", false);
			redFire = PlayerPrefsX.SetBool ("TheRedFireN", false);
			blueFire = PlayerPrefsX.SetBool ("TheBlueFireN", false);
			pinkShip = PlayerPrefsX.SetBool ("ThePinkShipN", false);
			greenFire = PlayerPrefsX.SetBool ("TheGreenFireN", false);
			blueShip = PlayerPrefsX.SetBool ("TheBlueShipN", false);
			redShip = PlayerPrefsX.SetBool ("TheRedShipN", false);



			PlayerPrefsX.SetBool ("pinkFireN", false);
			PlayerPrefsX.SetBool ("yellowFireN", false);
			PlayerPrefsX.SetBool ("blueFireN", false);
			PlayerPrefsX.SetBool ("greenFireN", false);
			PlayerPrefsX.SetBool ("redFireN", false);

			PlayerPrefsX.SetBool ("greenShipN", false);
			PlayerPrefsX.SetBool ("yellowShipN", false);
			PlayerPrefsX.SetBool ("pinkShipN", false);
			PlayerPrefsX.SetBool ("blueShipN", false);
			PlayerPrefsX.SetBool ("redShipN", false);

			PlayerPrefsX.SetBool ("Naut", false);

			normalF.isOn = true;
			normalS.isOn = true;

			PlayerPrefsX.SetBool ("rasberry", false);
		}
	}




	// Update is called once per frame
	public void onClick ()
	{



		pinkFire = PlayerPrefsX.SetBool ("ThePinkFireN", false);
		greenShip = PlayerPrefsX.SetBool ("TheGreenShipN", false);
		yellowFire = PlayerPrefsX.SetBool ("TheYellowFireN", false);
		yellowShip = PlayerPrefsX.SetBool ("TheYellowShipN", false);
		redFire = PlayerPrefsX.SetBool ("TheRedFireN", false);
		blueFire = PlayerPrefsX.SetBool ("TheBlueFireN", false);
		pinkShip = PlayerPrefsX.SetBool ("ThePinkShipN", false);
		greenFire = PlayerPrefsX.SetBool ("TheGreenFireN", false);
		blueShip = PlayerPrefsX.SetBool ("TheBlueShipN", false);
		redShip = PlayerPrefsX.SetBool ("TheRedShipN", false);



		PlayerPrefsX.SetBool ("pinkFireN", false);
		PlayerPrefsX.SetBool ("yellowFireN", false);
		PlayerPrefsX.SetBool ("blueFireN", false);
		PlayerPrefsX.SetBool ("greenFireN", false);
		PlayerPrefsX.SetBool ("redFireN", false);

		PlayerPrefsX.SetBool ("greenShipN", false);
		PlayerPrefsX.SetBool ("yellowShipN", false);
		PlayerPrefsX.SetBool ("pinkShipN", false);
		PlayerPrefsX.SetBool ("blueShipN", false);
		PlayerPrefsX.SetBool ("redShipN", false);

		normalF.isOn = true;
		normalS.isOn = true;





	}

}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClearTB : MonoBehaviour
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

		if (PlayerPrefsX.GetBool ("hi", true)) {

			pinkFire = PlayerPrefsX.SetBool ("ThePinkFireT", false);
			greenShip = PlayerPrefsX.SetBool ("TheGreenShipT", false);
			yellowFire = PlayerPrefsX.SetBool ("TheYellowFireT", false);
			yellowShip = PlayerPrefsX.SetBool ("TheYellowShipT", false);
			redFire = PlayerPrefsX.SetBool ("TheRedFireT", false);
			blueFire = PlayerPrefsX.SetBool ("TheBlueFireT", false);
			pinkShip = PlayerPrefsX.SetBool ("ThePinkShipT", false);
			greenFire = PlayerPrefsX.SetBool ("TheGreenFireT", false);
			blueShip = PlayerPrefsX.SetBool ("TheBlueShipT", false);
			redShip = PlayerPrefsX.SetBool ("TheRedShipT", false);



			PlayerPrefsX.SetBool ("pinkFireT", false);
			PlayerPrefsX.SetBool ("yellowFireT", false);
			PlayerPrefsX.SetBool ("blueFireT", false);
			PlayerPrefsX.SetBool ("greenFireT", false);
			PlayerPrefsX.SetBool ("redFireT", false);

			PlayerPrefsX.SetBool ("greenShipT", false);
			PlayerPrefsX.SetBool ("yellowShipT", false);
			PlayerPrefsX.SetBool ("pinkShipT", false);
			PlayerPrefsX.SetBool ("blueShipT", false);
			PlayerPrefsX.SetBool ("redShipT", false);

			PlayerPrefsX.SetBool ("Thunder", false);

			normalF.isOn = true;
			normalS.isOn = true;

			PlayerPrefsX.SetBool ("hi", false);
		}
	}




	// Update is called once per frame
	public void onClick ()
	{



		pinkFire = PlayerPrefsX.SetBool ("ThePinkFireT", false);
		greenShip = PlayerPrefsX.SetBool ("TheGreenShipT", false);
		yellowFire = PlayerPrefsX.SetBool ("TheYellowFireT", false);
		yellowShip = PlayerPrefsX.SetBool ("TheYellowShipT", false);
		redFire = PlayerPrefsX.SetBool ("TheRedFireT", false);
		blueFire = PlayerPrefsX.SetBool ("TheBlueFireT", false);
		pinkShip = PlayerPrefsX.SetBool ("ThePinkShipT", false);
		greenFire = PlayerPrefsX.SetBool ("TheGreenFireT", false);
		blueShip = PlayerPrefsX.SetBool ("TheBlueShipT", false);
		redShip = PlayerPrefsX.SetBool ("TheRedShipT", false);



		PlayerPrefsX.SetBool ("pinkFireT", false);
		PlayerPrefsX.SetBool ("yellowFireT", false);
		PlayerPrefsX.SetBool ("blueFireT", false);
		PlayerPrefsX.SetBool ("greenFireT", false);
		PlayerPrefsX.SetBool ("redFireT", false);

		PlayerPrefsX.SetBool ("greenShipT", false);
		PlayerPrefsX.SetBool ("yellowShipT", false);
		PlayerPrefsX.SetBool ("pinkShipT", false);
		PlayerPrefsX.SetBool ("blueShipT", false);
		PlayerPrefsX.SetBool ("redShipT", false);

		normalF.isOn = true;
		normalS.isOn = true;





	}

	void Update ()
	{


	}


}

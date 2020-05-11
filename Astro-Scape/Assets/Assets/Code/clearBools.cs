using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clearBools : MonoBehaviour
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

	//	public Toggle normalS;
	//	public Toggle normalF;




	//	public GameObject check;



	int parts;

	// Use this for initialization
	void Start ()
	{

		if (PlayerPrefsX.GetBool ("please", true)) {
			
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



			PlayerPrefsX.SetBool ("pinkFire", false);
			PlayerPrefsX.SetBool ("yellowFire", false);
			PlayerPrefsX.SetBool ("blueFire", false);
			PlayerPrefsX.SetBool ("greenFire", false);
			PlayerPrefsX.SetBool ("redFire", false);

			PlayerPrefsX.SetBool ("greenShip", false);
			PlayerPrefsX.SetBool ("yellowShip", false);
			PlayerPrefsX.SetBool ("pinkShip", false);
			PlayerPrefsX.SetBool ("blueShip", false);
			PlayerPrefsX.SetBool ("redShip", false);

			PlayerPrefsX.SetBool ("Golden", false);
			PlayerPrefsX.SetBool ("Thunder", false);
			PlayerPrefsX.SetBool ("Naut", false);

			PlayerPrefsX.SetBool ("nautlock", true);
			PlayerPrefsX.SetBool ("thunderlock", true);

//			normalF.isOn = true;
//			normalS.isOn = true;

			PlayerPrefsX.SetBool ("please", false);
		}
	}

	

	
	// Update is called once per frame
	public void onClick ()
	{
		PlayerPrefsX.SetBool ("nautlock", true);
		PlayerPrefsX.SetBool ("thunderlock", true);


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

		PlayerPrefsX.SetBool ("normalShip", true);
		PlayerPrefsX.SetBool ("normalFire", true);
		PlayerPrefsX.SetBool ("TheNormalShip", true);
		PlayerPrefsX.SetBool ("TheNormalFire", true);

	

		PlayerPrefsX.SetBool ("pinkFire", false);
		PlayerPrefsX.SetBool ("yellowFire", false);
		PlayerPrefsX.SetBool ("blueFire", false);
		PlayerPrefsX.SetBool ("greenFire", false);
		PlayerPrefsX.SetBool ("redFire", false);

		PlayerPrefsX.SetBool ("greenShip", false);
		PlayerPrefsX.SetBool ("yellowShip", false);
		PlayerPrefsX.SetBool ("pinkShip", false);
		PlayerPrefsX.SetBool ("blueShip", false);
		PlayerPrefsX.SetBool ("redShip", false);

//		normalF.isOn = true;
//		normalS.isOn = true;




	
	}

	void Update ()
	{

	
	}


}

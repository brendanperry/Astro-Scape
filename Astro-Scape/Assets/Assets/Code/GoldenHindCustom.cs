using UnityEngine;
using System.Collections;

public class GoldenHindCustom : MonoBehaviour {


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

	void Start () {

		normalFire = PlayerPrefsX.GetBool ("normalFire");
		redFire = PlayerPrefsX.GetBool ("redFire");
		blueFire = PlayerPrefsX.GetBool ("blueFire");
		yellowFire = PlayerPrefsX.GetBool ("yellowFire");
		greenFire = PlayerPrefsX.GetBool ("greenFire");
		pinkFire = PlayerPrefsX.GetBool("pinkFire");
		
		normalShip = PlayerPrefsX.GetBool("normalShip");
		redShip = PlayerPrefsX.GetBool ("redShip");
		blueShip = PlayerPrefsX.GetBool ("blueShip");
		yellowShip = PlayerPrefsX.GetBool ("yellowShip");
		greenShip = PlayerPrefsX.GetBool ("greenShip");
		pinkShip = PlayerPrefsX.GetBool ("pinkShip");

 

	}
	

	void Update () {

		normalFire = PlayerPrefsX.SetBool ("normalFire", normalFire);
		redFire = PlayerPrefsX.SetBool ("redFire", redFire);
		blueFire = PlayerPrefsX.SetBool ("blueFire", blueFire);
		yellowFire = PlayerPrefsX.SetBool ("yellowFire", yellowFire);
		greenFire = PlayerPrefsX.SetBool ("greenFire", greenFire);
		pinkFire = PlayerPrefsX.SetBool("pinkFire", pinkFire);
		
		normalShip = PlayerPrefsX.SetBool("normalShip", normalShip);
		redShip = PlayerPrefsX.SetBool ("redShip", redShip);
		blueShip = PlayerPrefsX.SetBool ("blueShip", blueShip);
		yellowShip = PlayerPrefsX.SetBool ("yellowShip", yellowShip);
		greenShip = PlayerPrefsX.SetBool ("greenShip", greenShip);
		pinkShip = PlayerPrefsX.SetBool ("pinkShip", pinkShip);
	
	}
}

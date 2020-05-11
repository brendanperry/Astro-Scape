using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LockedUp : MonoBehaviour {


	public bool redFireL;
	public bool blueFireL;
	public bool	yellowFireL;
	public bool	greenFireL;
	public bool pinkFireL;
	

	public bool redShipL;
	public bool blueShipL;
	public bool yellowShipL;
	public bool greenShipL;
	public bool pinkShipL;

	public Toggle redFire;
	public Toggle blueFire;
	public Toggle yellowFire;
	public Toggle greenFire;
	public Toggle pinkFire;
	
	
	public Toggle redShip;
	public Toggle blueShip;
	public Toggle yellowShip;
	public Toggle greenShip;
	public Toggle pinkShip;

	// Use this for initialization
	void Start () {


		redFireL = true;
		blueFireL = true;
		yellowFireL = true;
		greenFireL = true;
		pinkFireL = true;
		

		redShipL = true;
		blueShipL = true;
		yellowShipL = true;
		greenShipL = true;
		pinkShipL = true;

	
	}
	
	// Update is called once per frame
	void Update () {

		redFireL = PlayerPrefsX.GetBool ("redFireL");
		blueFireL = PlayerPrefsX.GetBool ("blueFireL");
		yellowFireL = PlayerPrefsX.GetBool ("yellowFireL");
		greenFireL = PlayerPrefsX.GetBool ("greenFireL");
		pinkFireL = PlayerPrefsX.GetBool("pinkFireL");
		
		
		redShipL = PlayerPrefsX.GetBool ("redShipL");
		blueShipL = PlayerPrefsX.GetBool ("blueShipL");
		yellowShipL = PlayerPrefsX.GetBool ("yellowShipL");
		greenShipL = PlayerPrefsX.GetBool ("greenShipL");
		pinkShipL = PlayerPrefsX.GetBool ("pinkShipL");

		if(redShipL == true){

			redShip.GetComponent<Toggle>().enabled = false;

		}
		else
		{
			redShip.GetComponent<Toggle>().enabled = true;
		}

		if(blueShipL == true){
			
			blueShip.GetComponent<Toggle>().enabled = false;
			
		}
		else
		{
			blueShip.GetComponent<Toggle>().enabled = true;
		}

		if(yellowShipL == true){
			
			yellowShip.GetComponent<Toggle>().enabled = false;
			
		}
		else
		{
			yellowShip.GetComponent<Toggle>().enabled = true;
		}

		if(greenShipL == true){
			
			greenShip.GetComponent<Toggle>().enabled = false;
			
		}
		else
		{
			greenShip.GetComponent<Toggle>().enabled = true;
		}

		if(pinkShipL == true){
			
			pinkShip.GetComponent<Toggle>().enabled = false;
			
		}
		else
		{
			pinkShip.GetComponent<Toggle>().enabled = true;
		}
	
	}
}

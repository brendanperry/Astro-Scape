using UnityEngine;
using System.Collections;

public class TBcustomSpawner : MonoBehaviour
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

	public GameObject NN;
	public GameObject NR;
	public GameObject NB;
	public GameObject NY;
	public GameObject NG;
	public GameObject NP;
	public GameObject RN;
	public GameObject RR;
	public GameObject RB;
	public GameObject RY;
	public GameObject RG;
	public GameObject RP;
	public GameObject GG;
	public GameObject GN;
	public GameObject GP;
	public GameObject GY;
	public GameObject GR;
	public GameObject GB;
	public GameObject YY;
	public GameObject YN;
	public GameObject YB;
	public GameObject YR;
	public GameObject YP;
	public GameObject YG;
	public GameObject PP;
	public GameObject PN;
	public GameObject PB;
	public GameObject PR;
	public GameObject PG;
	public GameObject PY;
	public GameObject BB;
	public GameObject BN;
	public GameObject BY;
	public GameObject BG;
	public GameObject BP;
	public GameObject BR;

	Vector3 position = new Vector3 (-2, -3, 96);

	void Awake ()
	{

		normalFire = PlayerPrefsX.GetBool ("normalFireT");
		redFire = PlayerPrefsX.GetBool ("redFireT");
		blueFire = PlayerPrefsX.GetBool ("blueFireT");
		yellowFire = PlayerPrefsX.GetBool ("yellowFireT");
		greenFire = PlayerPrefsX.GetBool ("greenFireT");
		pinkFire = PlayerPrefsX.GetBool ("pinkFireT");

		normalShip = PlayerPrefsX.GetBool ("normalShipT");
		redShip = PlayerPrefsX.GetBool ("redShipT");
		blueShip = PlayerPrefsX.GetBool ("blueShipT");
		yellowShip = PlayerPrefsX.GetBool ("yellowShipT");
		greenShip = PlayerPrefsX.GetBool ("greenShipT");
		pinkShip = PlayerPrefsX.GetBool ("pinkShipT");
	}


	void Update ()
	{

	}

	void Start ()
	{

		if (normalFire == false && normalShip == false && redFire == false && redShip == false && blueFire == false && blueShip == false && greenFire == false && greenShip == false && yellowFire == false && yellowShip == false && pinkFire == false && pinkShip == false) {

			GameObject gNNn = Instantiate (NN);
			gNNn.transform.position = position;
			gNNn.SetActive (true);

		} else if (normalFire && normalShip == true) {

			GameObject gNN = Instantiate (NN);
			gNN.transform.position = position;
			gNN.SetActive (true);

		} else if (normalFire && redShip == true) {

			GameObject gNR = Instantiate (RN);
			gNR.transform.position = position;
			gNR.SetActive (true);

		} else if (normalFire && blueShip == true) {

			GameObject gNB = Instantiate (BN);
			gNB.transform.position = position;
			gNB.SetActive (true);

		} else if (normalFire && yellowShip == true) {

			GameObject gNY = Instantiate (YN);
			gNY.transform.position = position;
			gNY.SetActive (true);

		} else if (normalFire && greenShip == true) {

			GameObject gNG = Instantiate (GN);
			gNG.transform.position = position;
			gNG.SetActive (true);

		} else if (normalFire && pinkShip == true) {

			GameObject gNP = Instantiate (PN);
			gNP.transform.position = position;
			gNP.SetActive (true);

		} else if (redFire && redShip == true) {

			GameObject gRR = Instantiate (RR);
			gRR.transform.position = position;
			gRR.SetActive (true);

		} else if (redFire && normalShip == true) {

			GameObject gRN = Instantiate (NR);
			gRN.transform.position = position;
			gRN.SetActive (true);

		} else if (redFire && blueShip == true) {

			GameObject gRB = Instantiate (BR);
			gRB.transform.position = position;
			gRB.SetActive (true);

		} else if (redFire && yellowShip == true) {

			GameObject gRY = Instantiate (YR);
			gRY.transform.position = position;
			gRY.SetActive (true);

		} else if (redFire && greenShip == true) {

			GameObject gRG = Instantiate (GR);
			gRG.transform.position = position;
			gRG.SetActive (true);
		} else if (redFire && pinkShip == true) {

			GameObject gRP = Instantiate (PR);
			gRP.transform.position = position;
			gRP.SetActive (true);
		} else if (blueFire && blueShip == true) {

			GameObject gBB = Instantiate (BB);
			gBB.transform.position = position;
			gBB.SetActive (true);

		} else if (blueFire && normalShip == true) {

			GameObject gBN = Instantiate (NB);
			gBN.transform.position = position;
			gBN.SetActive (true);

		} else if (blueFire && redShip == true) {

			GameObject gBR = Instantiate (RB);
			gBR.transform.position = position;
			gBR.SetActive (true);

		} else if (blueFire && yellowShip == true) {

			GameObject gBY = Instantiate (YB);
			gBY.transform.position = position;
			gBY.SetActive (true);

		} else if (blueFire && greenShip == true) {

			GameObject gBG = Instantiate (GB);
			gBG.transform.position = position;
			gBG.SetActive (true);
		} else if (blueFire && pinkShip == true) {

			GameObject gBP = Instantiate (PB);
			gBP.transform.position = position;
			gBP.SetActive (true);

		} else if (yellowFire && yellowShip == true) {

			GameObject gYY = Instantiate (YY);
			gYY.transform.position = position;
			gYY.SetActive (true);

		} else if (yellowFire && normalShip == true) {

			GameObject gYN = Instantiate (NY);
			gYN.transform.position = position;
			gYN.SetActive (true);

		} else if (yellowFire && redShip == true) {

			GameObject gYR = Instantiate (RY);
			gYR.transform.position = position;
			gYR.SetActive (true);

		} else if (yellowFire && blueShip == true) {

			GameObject gYB = Instantiate (BY);
			gYB.transform.position = position;
			gYB.SetActive (true);

		} else if (yellowFire && greenShip == true) {

			GameObject gYG = Instantiate (GY);
			gYG.transform.position = position;
			gYG.SetActive (true);

		} else if (yellowFire && pinkShip == true) {

			GameObject gYP = Instantiate (PY);
			gYP.transform.position = position;
			gYP.SetActive (true);
		} else if (greenFire && greenShip == true) {

			GameObject gGG = Instantiate (GG);
			gGG.transform.position = position;
			gGG.SetActive (true);
		} else if (greenFire && normalShip == true) {

			GameObject gGN = Instantiate (NG);
			gGN.transform.position = position;
			gGN.SetActive (true);
		} else if (greenFire && blueShip == true) {

			GameObject gGB = Instantiate (BG);
			gGB.transform.position = position;
			gGB.SetActive (true);

		} else if (greenFire && redShip == true) {

			GameObject gGR = Instantiate (RG);
			gGR.transform.position = position;
			gGR.SetActive (true);
		} else if (greenFire && yellowShip == true) {

			GameObject gGY = Instantiate (YG);
			gGY.transform.position = position;
			gGY.SetActive (true);

		} else if (greenFire && pinkShip == true) {

			GameObject gGP = Instantiate (PG);
			gGP.transform.position = position;
			gGP.SetActive (true);

		} else if (pinkFire && pinkShip == true) {

			GameObject gPP = Instantiate (PP);
			gPP.transform.position = position;
			gPP.SetActive (true);
		} else if (pinkFire && blueShip == true) {

			GameObject gPB = Instantiate (BP);
			gPB.transform.position = position;
			gPB.SetActive (true);
		} else if (pinkFire && greenShip == true) {

			GameObject gPG = Instantiate (GP);
			gPG.transform.position = position;
			gPG.SetActive (true);
		} else if (pinkFire && redShip == true) {

			GameObject gPR = Instantiate (RP);
			gPR.transform.position = position;
			gPR.SetActive (true);	

		} else if (pinkFire && normalShip == true) {

			GameObject gPN = Instantiate (NP);
			gPN.transform.position = position;
			gPN.SetActive (true);
		} else if (pinkFire && yellowShip == true) {

			GameObject gPY = Instantiate (YP);
			gPY.transform.position = position;
			gPY.SetActive (true);
		}

	}
}
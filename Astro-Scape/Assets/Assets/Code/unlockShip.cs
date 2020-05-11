using UnityEngine;
using System.Collections;


public class unlockShip : MonoBehaviour
{


	public GameObject yes;
	public GameObject no;
	public GameObject panel;
	public GameObject panel2;
	public GameObject txt;

	public void onClick ()
	{

		panel.SetActive (true);
		panel2.SetActive (true);
		yes.SetActive (true);
		no.SetActive (true);
		txt.SetActive (true);
	
	}
}

using UnityEngine;
using System.Collections;

public class nottoday : MonoBehaviour
{


	public GameObject yes;
	public GameObject no;
	public GameObject panel;
	public GameObject panel2;
	public GameObject txt;
	public GameObject yes1;

	public void onClick ()
	{

		panel.SetActive (false);
		panel2.SetActive (false);
		yes.SetActive (false);
		no.SetActive (false);
		txt.SetActive (false);
		yes1.SetActive (false);
	
	}
}

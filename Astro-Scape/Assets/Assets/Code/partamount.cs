using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class partamount : MonoBehaviour
{

	public int shipParts;

	Text txt;



	// Use this for initialization
	void Start ()
	{


	
	}
	
	// Update is called once per frame
	void Update ()
	{

		shipParts = PlayerPrefs.GetInt ("shipParts", shipParts);
		if (shipParts < 0) {
			shipParts = 0;
		}

		txt = GetComponent<Text> ();
		txt.text = "" + (shipParts);


	
	}
}

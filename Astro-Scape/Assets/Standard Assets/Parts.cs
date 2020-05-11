using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Parts : MonoBehaviour
{


	public int parts;

	//private int parts = 0;

	void Start ()
	{

		parts = PlayerPrefs.GetInt ("shipParts", parts);
	
	}


	public void Update ()
	{


		PlayerPrefs.GetInt ("shipParts", parts);
		parts = PlayerPrefs.GetInt ("shipParts", parts);

		//	GameObject partText = GameObject.Find ("show total parts");
		//	Text[] textValue = partText.GetComponents<Text> ();
		//	textValue [parts].text ="\nParts: " + (shipParts);
	
	}
}

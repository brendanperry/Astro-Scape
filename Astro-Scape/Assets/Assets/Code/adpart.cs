using UnityEngine;
using System.Collections;

public class adpart : MonoBehaviour
{

	public int addit = 5;
	
	static int shipParts;
	
	// Use this for initialization
	void Start ()
	{
		
		shipParts = PlayerPrefs.GetInt ("shipParts");
		
	}
	
	// Update is called once per frame
	public void onClick ()
	{
		
		shipParts += addit;
		PlayerPrefs.SetInt ("shipParts", shipParts);
		//PlayerPrefs.SetFloat ("TimeTillAd", 180);
	 

		
	}

	void Update ()
	{

		//PlayerPrefs.SetInt ("shipParts", shipParts);
	}
}

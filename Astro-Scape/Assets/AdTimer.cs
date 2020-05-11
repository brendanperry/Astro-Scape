using UnityEngine;
using System.Collections;

public class AdTimer : MonoBehaviour
{

	public float TimeTillAd = 180;
	bool AdOnStart;

	
	void Start ()
	{
		TimeTillAd = 300;

		TimeTillAd -= TimeMaster.instance.CheckDate ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		TimeTillAd -= Time.deltaTime;
	
		if (TimeTillAd <= 0) {

			TimeTillAd = 0;
			//PlayerPrefs.SetFloat ("TimeTillAd", TimeTillAd); 

		}
	}

	void GetFloat ()
	{

		//TimeTillAd = PlayerPrefs.GetFloat ("TimeTillAd");
	}
}

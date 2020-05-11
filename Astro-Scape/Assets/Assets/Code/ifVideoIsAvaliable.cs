using UnityEngine;
using System.Collections;
//using ChartboostSDK;
using UnityEngine.UI;

public class ifVideoIsAvaliable : MonoBehaviour
{

	public string Location;

	void Awake ()
	{

		//Chartboost.cacheRewardedVideo (CBLocation.Default);

	}

	void Start ()
	{

	}


	void Update ()
	{
		GameObject Timer = GameObject.Find ("Ad Timer");

		/*if (Chartboost.hasRewardedVideo (CBLocation.Default) && Timer.GetComponent<AdTimer> ().TimeTillAd <= 0) {

			gameObject.GetComponent<Image> ().enabled = true;
			gameObject.GetComponent<Button> ().enabled = true;

		} else {
			gameObject.GetComponent<Image> ().enabled = false;
			gameObject.GetComponent<Button> ().enabled = false;

		}*/
	}
	
}
	

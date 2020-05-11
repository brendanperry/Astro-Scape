using UnityEngine;
using System.Collections;
//using ChartboostSDK;
using UnityEngine.UI;

public class adManagement : MonoBehaviour
{

	public string Location;
	//int shipParts;

	public string sceneToLoad;

	void Start ()
	{
		//shipParts = PlayerPrefs.GetInt ("shipParts");
		//Chartboost.cacheRewardedVideo (CBLocation.Default);

	}

	public void onClick ()
	{

		//if (Chartboost.hasRewardedVideo (CBLocation.Default)) {

			//Chartboost.showRewardedVideo (CBLocation.Default); 

			//Chartboost.didCompleteRewardedVideo += Chartboost_didCompleteRewardedVideo;

				
		}
	}
/*
	void Chartboost_didCompleteRewardedVideo ( CBLocation arg1, int arg2 )
	{
		Application.LoadLevel (sceneToLoad);
		GameObject Timer = GameObject.Find ("Ad Timer");
		Timer.GetComponent<AdTimer> ().TimeTillAd = 300;
		TimeMaster.instance.SaveDate ();
	}
    */

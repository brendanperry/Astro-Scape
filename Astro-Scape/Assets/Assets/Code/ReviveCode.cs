using UnityEngine;
using System.Collections;
//using ChartboostSDK;

public class ReviveCode : MonoBehaviour
{

	public string LevelToLoad;


	void Start ()
	{
		
		//Chartboost.cacheRewardedVideo (CBLocation.Default);

	}

	public void onClick ()
	{
        /*
		if (Chartboost.hasRewardedVideo (CBLocation.Default)) {

			Chartboost.showRewardedVideo (CBLocation.Default); 

			Chartboost.didCompleteRewardedVideo += Chartboost_didCompleteRewardedVideo;

        
		} */
	}
    /*
	void Chartboost_didCompleteRewardedVideo (CBLocation arg1, int arg2)
	{
		GameObject Timer = GameObject.Find ("Ad Timer");
		Timer.GetComponent<AdTimer> ().TimeTillAd = 300;
		TimeMaster.instance.SaveDate ();
		Application.LoadLevel (LevelToLoad);
	} */
}

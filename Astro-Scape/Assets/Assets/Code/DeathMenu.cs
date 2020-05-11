using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using ChartboostSDK;

public class DeathMenu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	public void onClick ()
	{

		GameObject Share = GameObject.Find ("Share");
		Share.GetComponent<Button> ().enabled = true;
		Share.GetComponentInChildren<Text> ().enabled = true;

		GameObject ScoreText = GameObject.Find ("ScoreText");
		ScoreText.GetComponent<Text> ().enabled = true;
		ScoreText.GetComponent<EndScore> ().enabled = true;

		GameObject restart = GameObject.Find ("restart");
		restart.GetComponent<Button> ().enabled = true;
		restart.GetComponentInChildren<Text> ().enabled = true;

		GameObject home = GameObject.Find ("HOME");
		home.GetComponent<Button> ().enabled = true;
		home.GetComponentInChildren<Text> ().enabled = true;

		GameObject txt = GameObject.Find ("Text 1");
		txt.GetComponent<Text> ().enabled = true;

		GameObject revive = GameObject.Find ("revive");
		revive.SetActive (false);

		GameObject ad = GameObject.Find ("Video Ad");
		ad.SetActive (false);

		GameObject nope = GameObject.Find ("Nope");
		nope.SetActive (false);

		GameObject revM = GameObject.Find ("rev");
		revM.GetComponent<Button> ().enabled = true;
		revM.GetComponentInChildren<Text> ().enabled = true;

		GameObject timer = GameObject.Find ("Ad Timer");

		//if (Chartboost.hasRewardedVideo (CBLocation.Default) && timer.GetComponent<AdTimer> ().TimeTillAd == 0) {
			GameObject video = GameObject.Find ("Video Ad");
			video.GetComponent<ifVideoIsAvaliable> ().enabled = true;
			video.GetComponent<Image> ().enabled = true;
			video.GetComponent<Button> ().enabled = true;
		

	
	}
}

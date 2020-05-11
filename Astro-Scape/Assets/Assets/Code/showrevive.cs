using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using ChartboostSDK;

public class showrevive : MonoBehaviour
{

	public GameObject revive;
	public GameObject ad;
	public GameObject nope;

	// Use this for initialization
	public void onClick ()
	{


		GameObject Share = GameObject.Find ("Share");
		Share.GetComponent<Button> ().enabled = false;
		Share.GetComponentInChildren<Text> ().enabled = false;

		GameObject ScoreText = GameObject.Find ("ScoreText");
		ScoreText.GetComponent<Text> ().enabled = false;
		ScoreText.GetComponent<EndScore> ().enabled = false;

		GameObject restart = GameObject.Find ("restart");
		restart.GetComponent<Button> ().enabled = false;
		restart.GetComponentInChildren<Text> ().enabled = false;

		GameObject home = GameObject.Find ("HOME");
		home.GetComponent<Button> ().enabled = false;
		home.GetComponentInChildren<Text> ().enabled = false;

		GameObject txt = GameObject.Find ("Text 1");
		txt.GetComponent<Text> ().enabled = false;

		GameObject video = GameObject.Find ("video");
		video.GetComponent<ifVideoIsAvaliable> ().enabled = false;
		video.GetComponent<Image> ().enabled = false;
		video.GetComponent<Button> ().enabled = false;
		//GameObject revive = GameObject.Find ("revive");
		revive.SetActive (true);

		//GameObject ad = GameObject.Find ("Video Ad");
		ad.SetActive (true);

		//GameObject nope = GameObject.Find ("Nope");
		nope.SetActive (true);

		GameObject revM = GameObject.Find ("rev");
		revM.GetComponent<Button> ().enabled = false;
		revM.GetComponentInChildren<Text> ().enabled = false;


		GameObject imag = GameObject.Find ("Image");
		imag.GetComponent<Image> ().enabled = true;

		GameObject spend = GameObject.Find ("revive");
		spend.GetComponent<Button> ().enabled = true;
		spend.GetComponentInChildren<Text> ().enabled = true;

		GameObject txtt = GameObject.Find ("revive for shards");
		txtt.GetComponent<Text> ().enabled = true;

		GameObject no = GameObject.Find ("Nope");
		no.GetComponentInChildren<Text> ().enabled = true;
		no.GetComponent<Button> ().enabled = true;

		GameObject freg = GameObject.Find ("Frag");
		freg.GetComponent<Image> ().enabled = true;

		GameObject scs = GameObject.Find ("score stuff");
		scs.GetComponent<scoreThings> ().enabled = true;

		GameObject timer = GameObject.Find ("Ad Timer");

		//if (Chartboost.hasRewardedVideo (CBLocation.Default) && timer.GetComponent<AdTimer> ().TimeTillAd == 0) {
			
			GameObject videos = GameObject.Find ("Video Ad");
			videos.GetComponent<Button> ().enabled = true;
			videos.GetComponentInChildren<Text> ().enabled = true;
			GameObject img = GameObject.Find ("Image (1)");
			img.GetComponent<Image> ().enabled = true;
		}
	
	}


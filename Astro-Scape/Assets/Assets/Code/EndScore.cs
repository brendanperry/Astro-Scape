using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Prime31;

public class EndScore : MonoBehaviour
{

	private static int score = 0;
	private static int highScore = 0;
	public string leaderboardID = "topscores";
	public string HighScore;
	public string Score;

	private GameObject gc;

	Text txt;

	//private int scores = 0;

	void Start ()
	{
		gc = GameObject.Find ("GameCenter MNGR");

		highScore = PlayerPrefs.GetInt (HighScore, 0);

		score = PlayerPrefs.GetInt (Score, 0);

		StartCoroutine (every ());

		if (score > highScore) {
			highScore = score;
			PlayerPrefs.SetInt (HighScore, highScore);
		//	GameCenterBinding.reportScore (highScore, leaderboardID);
		}

		txt = GetComponent<Text> ();
		txt.text = "high score: " + (int)(highScore);

		if (score >= 100 && PlayerPrefsX.GetBool ("naa", true)) {

			gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("hundredpoints");
			//GameCenterBinding.reportAchievement ("100points", 100);

		}

		if (score >= 500) {

			//GameCenterBinding.reportAchievement ("500points", 100);
			gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("fivehundredpoints");

		}

		if (highScore >= 500) {
			gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("fivehundredpoints");

		}
		if (highScore >= 100) {

			gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("hundredpoints");
		}
	
	}

	// Use this for initialization
	IEnumerator every ()
	{
		yield return new WaitForSeconds (.25f);
//		Everyplay.StopRecording ();
	//	Everyplay.SetMetadata ("score", score);
		StopCoroutine (every ());
	}

	public void IncreaseScore (int amount)
	{
		if (score > highScore) {
			highScore = score;
		}
	}
}
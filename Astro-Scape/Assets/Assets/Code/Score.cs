using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Prime31;

public class Score : MonoBehaviour
{

	public int score = 0;
	public bool addScore = false;
	static int highScore;
	public string HighScore;
	public string Scores;

	int scores = 0;

	public GameObject canvas;


	void Start ()
	{
		addScore = false;
		//addScore = true; 
		StartCoroutine (startPoints ());

		highScore = PlayerPrefs.GetInt (HighScore, 0);
		score = PlayerPrefs.GetInt (Scores, 0);

		InvokeRepeating ("GoScore", 0f, .12f);

		if (Application.loadedLevelName == "AstroGame" || Application.loadedLevelName == "AstroBird" || Application.loadedLevelName == "AstroNaut") {
			
			score = 0;
		}
	}

	IEnumerator startPoints ()
	{

		yield return new WaitForSeconds (2);
		addScore = true;
		StopCoroutine (startPoints ());
			
	}

	// Use this for initialization
	void Update ()
	{
//		if (addScore == true) {
//			score++;
//		} else {
//			addScore = false;
//		}



		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [scores].text = " " + (int)(score);



		if (score > highScore) {
			highScore = score;


		}
	
	}
	
	// Update is called once per frame
	public void IncreaseScore (int amount)
	{
	
		score += amount;

		if (score > highScore) {
			highScore = score;
		}
	}


	void OnDestroy ()
	{
		
		PlayerPrefs.SetInt (HighScore, highScore);
		PlayerPrefs.SetInt (Scores, score);
	}

	void  GoScore ()
	{


		if (addScore == true) {
			
			score += 1;
		}

		if (addScore == false) {

			PlayerPrefs.SetInt (Scores, score);
		}
	}
}
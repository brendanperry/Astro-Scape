using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class blankFromHS : MonoBehaviour
{

	public Text it;
	public int highScore;
	public int score = 0;
	public float difference;
	bool no;

	public string HighScore;
	public string Score;

	bool isBlinking = true;

	string textToFlash = "new highscore!";
	string blankText = "";


	void Awake ()
	{
		
		highScore = PlayerPrefs.GetInt (HighScore, 0);

		score = PlayerPrefs.GetInt (Score, 0);
	}

	void Start ()
	{
		difference = (highScore) - (score);

		it.GetComponent<Text> ();

		if (highScore > score) {
			
			it.text = " (" + (int)difference + " away from high score)";
		} else {
			it.fontSize = 40;
			it.text = "new highscore!";
			StartCoroutine (BlinkText ());

		}

	}

	public IEnumerator BlinkText ()
	{
		
		while (isBlinking) {
			
			it.text = blankText;

			yield return new WaitForSeconds (.5f);

			it.text = textToFlash;
			yield return new WaitForSeconds (.5f); 
		}
	}
}
	

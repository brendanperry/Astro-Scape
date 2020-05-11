	using UnityEngine;
	using System.Collections;
	using UnityEngine.UI;
	
	public class HindAdScore : MonoBehaviour {
		
		static float score = 0;
		public bool addScore = true; 
		static float highScore;
		
		int scores = 0;
		
		
		void Start(){
			addScore = true; 
			
			
			highScore = PlayerPrefs.GetFloat ("highScore", 0);
			
		}
		
		// Use this for initialization
		void Update () {
			if (addScore == true) {
				score += Time.deltaTime;
			} else {
				addScore = false;
			}
			
			GameObject canvas = GameObject.Find ("Canvas1");
			Text[] textValue = canvas.GetComponentsInChildren<Text> ();
			textValue [scores].text = " " +(int)(score*10);
			
			PlayerPrefs.SetFloat("Score",score);
			
			if (score > highScore) {
				highScore = score;
				
			}
			
		}
		
		// Update is called once per frame
		public void IncreaseScore (int amount) {
			
			score += amount;
			
			if (score > highScore) {
				highScore = score;
			}
		} 
		void OnDestroy(){
			
			PlayerPrefs.SetFloat ("highScore", highScore);
			PlayerPrefs.SetFloat ("score", score);
		}
	}
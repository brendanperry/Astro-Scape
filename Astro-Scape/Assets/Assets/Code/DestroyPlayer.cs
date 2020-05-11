using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using ChartboostSDK;

public class DestroyPlayer : MonoBehaviour
{

	Score scoreScript;


	Animator anim;

	public float deathMenuDelayTime = 2f;

	IEnumerator OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Player" && GetComponent<Renderer>().isVisible) {

			GetComponent<AudioSource> ().volume = .75f;

			anim = GetComponent<Animator> ();
			anim.SetBool ("Destroy", true);



			Vector3 pos = new Vector3 (0, 0, -5);
			gameObject.transform.position += pos;

			GetComponent<AudioSource> ().Play ();

			GameObject ship = GameObject.FindGameObjectWithTag ("Player");
			ship.GetComponent<Controller> ().isAlive = false;   


			//GetComponent<MeteoroidMove> ().speed = 1;
			ship.GetComponent<Controller> ().Speed = 1;

			GameObject go = GameObject.Find ("GoingUp");
			go.GetComponent<MeteoroidMove> ().speed = -1;

			yield return new WaitForSeconds (.25f);
		
			go.GetComponent<MeteoroidMove> ().speed = -6;
			
			yield return new WaitForSeconds (deathMenuDelayTime);
			
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

			GameObject scs = GameObject.Find ("score stuff");
			scs.GetComponent<scoreThings> ().enabled = true;

		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using ChartboostSDK;
//using Prime31;

public class Controller : MonoBehaviour
{
	
	public float Speed = 5f;
	private bool goingRight;
	public bool hit = false;

	public bool paused = false;
	public bool invincible = false;
	public bool vibrate;

	Animator animator;

	public bool toggle;

	static int playCount;

	public bool isAlive = true;

	public int totalDeaths;

	Score scoreScript;

	private GameObject gc;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (hyperspeed ());

		gc = GameObject.Find ("GameCenter MNGR");

		animator = GetComponent<Animator> ();

		goingRight = true;
		hit = false;
		paused = false;

		toggle = PlayerPrefsX.GetBool ("toggle");
		vibrate = PlayerPrefsX.GetBool ("vibrate");

		isAlive = true;

		playCount++;

		totalDeaths = PlayerPrefs.GetInt ("totalDeaths");

		GetComponent<AudioSource> ().volume = .5f;

		scoreScript = GameObject.Find ("Text").GetComponent<Score> ();

		if (Application.loadedLevel == 2 || Application.loadedLevel == 3 || Application.loadedLevel == 4 || Application.loadedLevel == 17 || Application.loadedLevel == 18 || Application.loadedLevel == 19) {
			GameObject cam = GameObject.Find ("GoingUp");
			transform.parent = cam.transform;
		}



	}
	
	// Update is called once per frame
	void Update ()
	{

			
		if (goingRight == true && paused == false) {
			transform.position += Vector3.right * Speed * Time.deltaTime;     
		} else {
			transform.position += Vector3.left * Speed * Time.deltaTime;
		}
		if (isAlive == true) {
	
			if (Input.GetMouseButtonDown (0)) {
				goingRight = !goingRight;
			}
		}

		// ...
			
		// 6 - Make sure we are not outside the camera bounds
		var dist = (transform.position - Camera.main.transform.position).z;
			
		var leftBorder = Camera.main.ViewportToWorldPoint (
			                 new Vector3 (0, 0, dist)
		                 ).x;
			
		var rightBorder = Camera.main.ViewportToWorldPoint (
			                  new Vector3 (1, 0, dist)
		                  ).x;
			
		var topBorder = Camera.main.ViewportToWorldPoint (
			                new Vector3 (0, 0, dist)
		                ).y;
			
		var bottomBorder = Camera.main.ViewportToWorldPoint (
			                   new Vector3 (0, 1, dist)
		                   ).y;
			
		transform.position = new Vector3 (
			Mathf.Clamp (transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp (transform.position.y, topBorder, bottomBorder),
			transform.position.z


		);

	}

	void OnTriggerEnter2D (Collider2D coll)
	{


		if (coll.gameObject.CompareTag ("M") && coll.GetComponent<Renderer>().isVisible) {

			if (scoreScript.addScore == true) {
				scoreScript.addScore = false;
			}



			totalDeaths++;
			PlayerPrefs.SetInt ("totalDeaths", totalDeaths);

			GetComponent<AudioSource> ().Play ();

			gameObject.GetComponent<Collider2D> ().enabled = false;

			animator.SetBool ("Destroy", true);


			GameObject pause = GameObject.Find ("PauseButton");
			pause.SetActive (false);





			if (toggle == true) {
				Camera.main.GetComponent<CameraShake> ().enabled = true;
			}

			if (PlayerPrefs.GetInt ("totalDeaths") >= 100) {

				//GameCenterBinding.reportAchievement ("death", 100);

				gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("death");

			}
		}
	}

	IEnumerator hyperspeed ()
	{

		GetComponent<Animator> ().speed = 2;
		yield return new WaitForSeconds (1);
		GetComponent<Animator> ().speed = 1;
		
	}
}


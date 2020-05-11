using UnityEngine;
using System.Collections;

public class givepart : MonoBehaviour
{

	public int parts = 1;

	public Sprite shard;

	// Use this for initialization
	void OnEnable ()
	{
		gameObject.GetComponent<Collider2D> ().enabled = true;
		//parts = PlayerPrefs.GetInt ("shipParts");

		//GetComponent<Animator> ().Play ("entry", -1, 0f);
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.tag == "Player") {


			parts = PlayerPrefs.GetInt ("shipParts");
			parts++;
			gameObject.GetComponent<Collider2D> ().enabled = false;
			GetComponent<AudioSource> ().Play ();
			PlayerPrefs.SetInt ("shipParts", parts);
			//	GetComponent<Animator> ().SetBool ("Destroy", true);
			GetComponent<Animator> ().Play ("dorm", -1, 0f);

		}
	
	}

	void OnDisable ()
	{

		GetComponent<SpriteRenderer> ().sprite = shard;
	}
}

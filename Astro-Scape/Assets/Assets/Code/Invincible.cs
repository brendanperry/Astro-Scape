using UnityEngine;
using System.Collections;

public class Invincible : MonoBehaviour {

	public GameObject shield;

	int TimeOn = 5;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	IEnumerator OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "Player") {


			GameObject shield = GameObject.Find ("Shield");
			shield.GetComponent<Collider2D> ().enabled = true;
			Debug.Log ("Shield is back online");

			gameObject.GetComponent<Collider2D>().enabled = false;
			gameObject.GetComponent<SpriteRenderer>().enabled = false;


			yield return new WaitForSeconds (TimeOn);

			GameObject shields = GameObject.Find("Shield");
			shields.GetComponent<Collider2D>().enabled = false;
			Debug.Log ("Shield is dead");

			Destroy (this.gameObject);
		
		
		}
	}
}
using UnityEngine;
using System.Collections;

public class dactivation : MonoBehaviour
{

	void OnEnable ()
	{
		Invoke ("Destroy", 4f);

	}

	void Destroy ()
	{
		gameObject.SetActive (false);
	}

	void OnDisable ()
	{
		
		CancelInvoke ();

	}

	void OnTriggerEnter2D (Collider2D col)
	{

		if (col.tag == "M") {

			gameObject.SetActive (false);
		}

		if (col.tag == "S") {

			col.gameObject.SetActive (false);
		}
	}
}
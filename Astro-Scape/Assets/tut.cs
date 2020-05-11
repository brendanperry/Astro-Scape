using UnityEngine;
using System.Collections;

public class tut : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		GameObject gc = GameObject.Find ("GameCenter MNGR");
		gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("tutorial");
	
	}
}
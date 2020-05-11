using UnityEngine;
using System.Collections;

public class ReviveToDeath : MonoBehaviour {

	public GameObject deathMenu;



	public GameObject canvas;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	public void onClick () {

	
		deathMenu.transform.parent = canvas.transform;
	
	}
}

using UnityEngine;
using System.Collections;

public class buy : MonoBehaviour {

	public GameObject menu;





	// Use this for initialization
	void Start () {

		menu.SetActive (false);

	
	}
	
	// Update is called once per frame
	public void onClick () {

		menu.SetActive (true);
		
	}
}

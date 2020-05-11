using UnityEngine;
using System.Collections;

public class SoundEffects : MonoBehaviour {

	public GameObject soundEffect;



	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	public void onClick () {

		Instantiate(soundEffect);
	
	}
}

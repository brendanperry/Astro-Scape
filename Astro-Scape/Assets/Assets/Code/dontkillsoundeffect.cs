using UnityEngine;
using System.Collections;

public class dontkillsoundeffect : MonoBehaviour {

	// Use this for initialization
	void Start () {

		DontDestroyOnLoad (gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {

		Destroy (gameObject, 1f);
	
	}
}

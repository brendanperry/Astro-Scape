using UnityEngine;
using System.Collections;

public class dontkillaudio : MonoBehaviour
{

	//	public string scene;
	//	public string scene2;
	//	public string scene3;

	public GameObject AudioMenu;
	public GameObject AudioGame;

	//static bool AudioBegin = false;

	private static dontkillaudio instance = null;

	public static dontkillaudio Instance {
		
		get { return instance; }
	}

	void Awake ()
	{
		
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}

	void Start ()
	{

		//GetComponent<AudioSource> ().Play ();


		AudioMenu.SetActive (true);
		AudioGame.SetActive (false);

	}


	void Update ()
	{
//		if (Application.loadedLevelName == scene || Application.loadedLevelName == scene2 || Application.loadedLevelName == scene3) {
//			GetComponent<AudioSource> ().Stop ();
//
//		} else {
//
//			GetComponent<AudioSource> ().Play ();
//		}
		
	}

	void OnLevelWasLoaded (int level)
	{

		if (level == 1 || level == 6 || level == 9 || level == 8 || level == 11 || level == 12 || level == 13 || level == 7 || level == 5 || level == 15 || level == 16 || level == 10 || level == 14 || level == 20) {
			
			//GetComponent<AudioSource> ().Play ();
			AudioGame.SetActive (false);
			AudioMenu.SetActive (true);
		} else {
			AudioGame.SetActive (true);
			AudioMenu.SetActive (false);
		}

	}
}

using UnityEngine;
using System.Collections;

public class dontkillgame : MonoBehaviour
{





	private static dontkillgame instance = null;

	public static dontkillgame Instance {

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
		

		GetComponent<AudioSource> ().Play ();


	}


	void Update ()
	{
		if (Application.loadedLevelName == "AstroMenu") {
			GetComponent<AudioSource> ().Stop ();

		}

		if (Application.loadedLevelName == "AstroGame" || Application.loadedLevelName == "AstroNaut" || Application.loadedLevelName == "AstroGame") {

			GetComponent<AudioSource> ().Play ();
		}
	}
}

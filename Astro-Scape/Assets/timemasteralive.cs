using UnityEngine;
using System.Collections;

public class timemasteralive : MonoBehaviour
{

	private static timemasteralive instance = null;

	public static timemasteralive Instance {

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
}
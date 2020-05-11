using UnityEngine;
using System.Collections;

public class KeepTimer : MonoBehaviour
{

	private static KeepTimer instance = null;

	public static KeepTimer Instance {

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
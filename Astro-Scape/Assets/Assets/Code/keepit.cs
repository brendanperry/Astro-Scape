using UnityEngine;
using System.Collections;

public class keepit : MonoBehaviour
{

	private static keepit instance = null;

	public static keepit Instance {

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
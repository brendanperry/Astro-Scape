using UnityEngine;
using System.Collections;

public class bg2 : MonoBehaviour
{

	private static bg2 instance = null;

	public static bg2 Instance {

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
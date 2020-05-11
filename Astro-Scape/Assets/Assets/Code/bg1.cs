using UnityEngine;
using System.Collections;

public class bg1 : MonoBehaviour
{

	private static bg1 instance = null;

	public static bg1 Instance {

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
using UnityEngine;
using System.Collections;

public class bg3 : MonoBehaviour
{

	private static bg3 instance = null;

	public static bg3 Instance {

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
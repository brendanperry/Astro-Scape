using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour
{


	public void ChangeToScene ( string ThisScene )
	{
		//Application.LoadLevel (ThisScene);

		if (Application.loadedLevel == 20 && PlayerPrefsX.GetBool ("scenetoload", true)) {

			PlayerPrefsX.SetBool ("scenetoload", false);
			GameObject gc = GameObject.Find ("GameCenter MNGR");
			gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("tutorial");
			Application.LoadLevel (ThisScene);
		} else {
			Application.LoadLevel (ThisScene);
		}

	}
}

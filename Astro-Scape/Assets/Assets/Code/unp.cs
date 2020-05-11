using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class unp : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	public void OnClick ()
	{

		GameObject pmenu = GameObject.Find ("PauseMenu");
		GameObject parent = GameObject.Find ("GoingUp");
		pmenu.transform.parent = parent.transform;

		GameObject ship = GameObject.FindGameObjectWithTag ("Player");
		ship.GetComponent<Controller> ().paused = false;

		Time.timeScale = 1;

		GameObject pimage = GameObject.Find ("PauseImage");
		pimage.GetComponent<Image> ().enabled = true;
	
	}
}

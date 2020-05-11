using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	public void OnClick ()
	{

		GameObject pmenu = GameObject.Find ("PauseMenu");
		GameObject canvas = GameObject.Find ("Canvas");
		pmenu.transform.parent = canvas.transform;

	
	
	}
}

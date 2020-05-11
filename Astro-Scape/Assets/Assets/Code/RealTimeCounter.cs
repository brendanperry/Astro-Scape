using UnityEngine;
using System.Collections;

public class RealTimeCounter : MonoBehaviour
{

	public float timer;

	// Use this for initialization
	void Start ()
	{
	
		timer = 300;

		timer -= TimeMaster.instance.CheckDate ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		timer -= Time.deltaTime;
	}

	void OnGUI ()
	{

		if (GUI.Button (new Rect (10, 10, 100, 50), "Save Time")) {
			ResetClock ();
		}
		if (GUI.Button (new Rect (10, 150, 100, 50), "Check Time")) {

			print (60 - TimeMaster.instance.CheckDate () + "in real seconds has passed");
		}

		GUI.Label (new Rect (10, 150, 100, 50), timer.ToString ());
	}

	void ResetClock ()
	{
		TimeMaster.instance.SaveDate ();
		timer = 300;
		timer -= TimeMaster.instance.CheckDate ();

	}
}

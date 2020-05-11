using UnityEngine;
using System.Collections;

public class GenRate : MonoBehaviour
{

	public GameObject spawn;
	public GameObject spawn2;
	public GameObject spawn3;
	public GameObject spawn4;

	public float Ftime;
	public float Ftime2;
	public float Ftime3;
	public float Ftime4;

	public float Fdiff;

	public float Fdiff2;

	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		Ftime = spawn.GetComponent<Spawner> ().fireTime;
		Ftime2 = spawn2.GetComponent<Spawner> ().fireTime;
		Ftime3 = spawn3.GetComponent<Spawner> ().fireTime;
		Ftime4 = spawn4.GetComponent<Spawner> ().fireTime;
	

		if (Ftime - Ftime2 <= .25f) {

			Ftime -= .3f;
		}

		if (Ftime2 - Ftime <= .25f) {

			Ftime2 -= .3f;
		}

		if (Ftime3 - Ftime4 <= .25f) {

			Ftime4 -= .4f;
		}

		if (Ftime4 - Ftime3 <= .25f) {

			Ftime3 -= .4f;
		}

		if (Ftime - Ftime3 >= .25f) {

			Ftime3 += .1f;
		}

		if (Ftime3 - Ftime >= .25f) {

			Ftime += .01f;
		}

		if (Ftime4 - Ftime2 >= .25f) {

			Ftime2 += .35f;
		}

		if (Ftime2 - Ftime4 >= .25f) {

			Ftime4 += .25f;
		}

		if (Ftime2 - Ftime3 >= .25f) {

			Ftime2 += .15f;
		}

		if (Ftime3 - Ftime2 >= .25f) {

			Ftime3 -= .25f;
		}
	}
}

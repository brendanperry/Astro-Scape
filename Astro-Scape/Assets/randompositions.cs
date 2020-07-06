using UnityEngine;
using System.Collections;

public class randompositions : MonoBehaviour
{

	public GameObject pos1;
	public GameObject pos2;
	public GameObject pos3;
	public GameObject pos4;

	public int random;

	void Start ()
	{
		Vector3 current = new Vector3(-3, pos1.transform.position.y, 0);
		Vector3 current2 = new Vector3(3, pos2.transform.position.y, 0);
		Vector3 current3 = new Vector3(-1.7f, pos3.transform.position.y, 0);
		Vector3 current4 = new Vector3(1.6f, pos4.transform.position.y, 0);


		random = Random.Range (1, 5);

		if (random == 1) {

			pos1.transform.position = current;
			pos2.transform.position = current2;
			pos3.transform.position = new Vector3(current3.x + Random.Range(-.75f, 1f), current3.y, 0);
			pos4.transform.position = new Vector3(current4.x - Random.Range(-.75f, 1f), current4.y, 0);

		} else if (random == 2) {

			pos1.transform.position = current2;
			pos2.transform.position = new Vector3(current3.x + Random.Range(-.75f, 1f), current3.y, 0);
			pos3.transform.position = new Vector3(current4.x - Random.Range(-.75f, 1f), current4.y, 0);
			pos4.transform.position = current;
		} else if (random == 3) {

			pos1.transform.position = new Vector3(current3.x + Random.Range(-.75f, 1f), current3.y, 0);
			pos2.transform.position = new Vector3(current4.x - Random.Range(-.75f, 1f), current4.y, 0);
			pos3.transform.position = current;
			pos4.transform.position = current2;
		} else if (random == 4) {

			pos1.transform.position = new Vector3(current4.x - Random.Range(-.75f, 1f), current4.y, 0);
			pos2.transform.position = current;
			pos3.transform.position = current2;
			pos4.transform.position = new Vector3(current3.x + Random.Range(-.75f, 1f), current3.y, 0);
		}

		InvokeRepeating ("MORErandom", 2, 2);
	
	}

	void MORErandom ()
	{

		Vector3 current = new Vector3(-3, pos1.transform.position.y, 0);
		Vector3 current2 = new Vector3(3, pos2.transform.position.y, 0);
		Vector3 current3 = new Vector3(-1.7f, pos3.transform.position.y, 0);
		Vector3 current4 = new Vector3(1.6f, pos4.transform.position.y, 0);



		random = Random.Range (1, 5);

		if (random == 1) {

			pos1.transform.position = current;
			pos2.transform.position = current2;
			pos3.transform.position = new Vector3(current3.x + Random.Range(0, 1f), current3.y, 0);
			pos4.transform.position = new Vector3(current4.x - Random.Range(0, 1f), current4.y, 0);

		} else if (random == 2) {

			pos1.transform.position = current2;
			pos2.transform.position = new Vector3(current3.x + Random.Range(0, 1f), current3.y, 0);
			pos3.transform.position = new Vector3(current4.x - Random.Range(0, 1f), current4.y, 0);
			pos4.transform.position = current;
		} else if (random == 3) {

			pos1.transform.position = new Vector3(current3.x + Random.Range(0, 1f), current3.y, 0);
			pos2.transform.position = new Vector3(current4.x - Random.Range(0, 1f), current4.y, 0);
			pos3.transform.position = current;
			pos4.transform.position = current2;
		} else if (random == 4) {

			pos1.transform.position = new Vector3(current4.x - Random.Range(0, 1f), current4.y, 0);
			pos2.transform.position = current;
			pos3.transform.position = current2;
			pos4.transform.position = new Vector3(current3.x + Random.Range(0, 1f), current3.y, 0);
		}
	}
}

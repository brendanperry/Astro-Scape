using UnityEngine;
using System.Collections;

public class randompositions : MonoBehaviour
{

	public GameObject pos1;
	public GameObject pos2;
	public GameObject pos3;
	public GameObject pos4;
	public GameObject pos5;

	public int random;

	//	Vector2 one;
	//	Vector2 two;
	//	Vector2 three;
	//	Vector2 four;

	// Use this for initialization
	void Start ()
	{
//		Vector2 one = pos1.transform.position;
//		Vector2 two = pos2.transform.position;
//		Vector2 three = pos3.transform.position;
//		Vector2 four = pos4.transform.position;

		Vector3 current = pos1.transform.position;
		Vector3 current2 = pos2.transform.position;
		Vector3 current3 = pos3.transform.position;
		Vector3 current4 = pos4.transform.position;
		Vector3 current5 = pos5.transform.position;


		random = Random.Range (1, 6);

		if (random == 1) {

			pos1.transform.position = current;
			pos2.transform.position = current2;
			pos3.transform.position = current3;
			pos4.transform.position = current4;
			pos5.transform.position = current5;

		} else if (random == 2) {

			pos1.transform.position = current2;
			pos2.transform.position = current3;
			pos3.transform.position = current4;
			pos5.transform.position = current5;
			pos4.transform.position = current;
		} else if (random == 3) {

			pos1.transform.position = current3;
			pos2.transform.position = current4;
			pos3.transform.position = current;
			pos4.transform.position = current2;
			pos5.transform.position = current5;
		} else if (random == 4) {

			pos1.transform.position = current4;
			pos2.transform.position = current;
			pos3.transform.position = current2;
			pos4.transform.position = current3;
			pos5.transform.position = current5;
		}
		else if(random == 5) {
			pos1.transform.position = current4;
			pos5.transform.position = current;
			pos3.transform.position = current2;
			pos4.transform.position = current3;
			pos2.transform.position = current5;
		}

		InvokeRepeating ("MORErandom", 2, 2);
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void MORErandom ()
	{

		Vector3 current = pos1.transform.position;
		Vector3 current2 = pos2.transform.position;
		Vector3 current3 = pos3.transform.position;
		Vector3 current4 = pos4.transform.position;
		Vector3 current5 = pos5.transform.position;


		random = Random.Range (1, 6);

		if (random == 1) {

			pos1.transform.position = current;
			pos2.transform.position = current2;
			pos3.transform.position = current3;
			pos4.transform.position = current4;
			pos5.transform.position = current5;

		} else if (random == 2) {

			pos1.transform.position = current2;
			pos2.transform.position = current3;
			pos3.transform.position = current4;
			pos5.transform.position = current5;
			pos4.transform.position = current;
		} else if (random == 3) {

			pos1.transform.position = current3;
			pos2.transform.position = current4;
			pos3.transform.position = current;
			pos4.transform.position = current2;
			pos5.transform.position = current5;
		} else if (random == 4) {

			pos1.transform.position = current4;
			pos2.transform.position = current;
			pos3.transform.position = current2;
			pos4.transform.position = current3;
			pos5.transform.position = current5;
		}
		else if(random == 5) {
			pos1.transform.position = current4;
			pos5.transform.position = current;
			pos3.transform.position = current2;
			pos4.transform.position = current3;
			pos2.transform.position = current5;
		}
	}
}

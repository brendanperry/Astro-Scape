using UnityEngine;
using System.Collections;

public class MeteoroidMove: MonoBehaviour
{

	public int speed = 6;

	float ypos;
	float xpos;

	Vector3 gravity = new Vector3 (0, -1, 0);

	// Update is called once per frame
	void Update ()
	{

		Vector2 camPos = transform.position;

		transform.position += gravity * speed * Time.deltaTime;

		if (camPos.y > 75.0f) {

			camPos.y = 0;
			camPos.x += 20;
		}


	}
}

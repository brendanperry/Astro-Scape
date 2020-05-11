using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour
{

	public float speed = .01f;
	public static Background current;

	float pos = 0;

	void Start ()
	{

		current = this;

	}

	void Update ()
	{

		pos += speed;
		if (pos > 1.0f)
			pos -= 1.0f;

		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (pos, 0);
	}

	void OnLevelWasLoaded (int level)
	{

		if (level == 2 || level == 3 || level == 4 || level == 17 || level == 18 || level == 19) {

			GameObject goup = GameObject.Find ("GoingUp");
			transform.parent = goup.transform;
			StartCoroutine (HyperSpeed ());
		}
	}

	IEnumerator HyperSpeed ()
	{

		float current = speed;
		if (gameObject.tag == "bg") {
			speed = .01f;
		} else if (gameObject.tag == "bg1") {
			speed = .03f;
			
		} else if (gameObject.tag == "bg2") {
			speed = .02f;
		}
		yield return new WaitForSeconds (.75f);
		speed = current;
		StopCoroutine (HyperSpeed ());
	}
}
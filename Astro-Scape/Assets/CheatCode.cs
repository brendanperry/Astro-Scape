using UnityEngine;
using System.Collections;

public class CheatCode : MonoBehaviour
{

	public GameObject Score;

	public void onClick ()
	{

		Score.GetComponent<Score> ().score += 25;
	
	}

}

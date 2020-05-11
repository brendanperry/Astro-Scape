using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour
{

	public float time = 5f;

	// Use this for initialization
	IEnumerator kill ()
	{
		yield return new WaitForSeconds (.3f);
		//gameObject.SetActive (false);
		Destroy (this.gameObject);
	
	}
	
	// Update is called once per frame
	void Start ()
	{
		StartCoroutine (kill ());
	}
}

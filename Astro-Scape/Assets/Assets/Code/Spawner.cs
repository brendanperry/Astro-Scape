using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{

	//public Transform spawnPoint;
	//public GameObject[] spawnObject;
	//public int spawnTotal;
	//public float timeBetweenSpawns;

	public GameObject pooledObject;
	public float fireTime = .05f;

	public int pooledAmount;
	List<GameObject> pooledObjects;

	public GameObject scorer;


	public float moreRandom;

	//	public float one;
	//	public float two;

	public float increase;

	void Start ()
	{
		

		pooledObjects = new List<GameObject> ();
		for (int i = 0; i < pooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate (pooledObject);
			obj.SetActive (false);
			pooledObjects.Add (obj);
		}

		fireTime = Random.Range(fireTime - .25f, fireTime + .25f);

		InvokeRepeating ("Fire", fireTime, fireTime);

	}
	
	// Update is called once per frame
	void Update ()
	{
		fireTime += increase * Time.deltaTime;
	}


	//	IEnumerator SpawnGameObject ()
	//	{
	//
	//		for (var x = 0; x < spawnTotal; x++) {
	//
	//			Instantiate (spawnObject [Random.Range (0, spawnObject.GetLength (0))], transform.position, Quaternion.identity);
	//			yield return new WaitForSeconds (timeBetweenSpawns);
	//		}
	//	}

	void Fire ()
	{
		for (int i = 0; i < pooledObjects.Count; i++) {
			if (!pooledObjects [i].activeInHierarchy) {
				pooledObjects [i].transform.position = new Vector3(transform.position.x, transform.position.y, 95);
				pooledObjects [i].transform.rotation = transform.rotation;
				if(pooledObjects [i].transform.localScale.x != 5) {
					float ran = Random.Range(3f, 5f);
					pooledObjects [i].transform.localScale = new Vector3(ran, ran, 1);
				}
				pooledObjects [i].SetActive (true);
				break;
			}
		}
	}
}
	

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
//using Prime31;
using UnityEngine.UI;
using System.Collections.Generic;

public class xplodeClick : MonoBehaviour
{
			
	public GameObject xp;
	public bool xplode = true;
	public Camera cam;
	public int amountOfTaps;

	public GameObject audios;

	private GameObject gc;

	void Start ()
	{

		gc = GameObject.Find ("GameCenter MNGR");
		//amountOfTaps = PlayerPrefs.GetInt()
	}

	void LateUpdate ()
	{

		if (xplode == true) {

			if (!IsPointerOverUIObject ()) {
					
				Vector3 mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y);
				
				if (Input.GetMouseButtonDown (0)) {
					amountOfTaps++;

					Instantiate (audios);
					
					Vector3 wordPos;
					Ray ray = cam.ScreenPointToRay (mousePos);
					RaycastHit hit;
					if (Physics.Raycast (ray, out hit, 1000f)) {
						wordPos = hit.point;
					} else {
						wordPos = cam.ScreenToWorldPoint (mousePos);
					}
					Instantiate (xp, wordPos, Quaternion.identity); 
				}
			}
		}
			

		if (amountOfTaps >= 100) {

			//GameCenterBinding.reportAchievement ("timewaster", 100);
			gc.GetComponent<GameCenterMNGR> ().StartCoroutine ("timewaster");

		}
	}

	private bool IsPointerOverUIObject ()
	{
		PointerEventData eventDataCurrentPosition = new PointerEventData (EventSystem.current);
		eventDataCurrentPosition.position = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);

		List<RaycastResult> results = new List<RaycastResult> ();
		EventSystem.current.RaycastAll (eventDataCurrentPosition, results);
		return results.Count > 0;
	}

}

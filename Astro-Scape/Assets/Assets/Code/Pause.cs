using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {



	// Use this for initialization
	void Start () {



	
	}
	
	// Update is called once per frame
	public void OnClick () {


		if(Time.timeScale == 1f){
					
			Time.timeScale = 0f;

			GameObject ship = GameObject.FindGameObjectWithTag("Player");
			ship.GetComponent<Controller>().paused = true;
				


			GameObject pimage = GameObject.Find ("PauseImage");
			pimage.GetComponent<Image>().enabled = false;
			

			
			}
			else
			{
				
			Time.timeScale = 1f;
				
			GameObject ship = GameObject.FindGameObjectWithTag("Player");
			ship.GetComponent<Controller>().paused = false;
			
	
			}
		}
	}
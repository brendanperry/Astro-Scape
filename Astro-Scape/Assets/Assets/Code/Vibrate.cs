using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Vibrate : MonoBehaviour {


	public bool vibrate;
	public Toggle tog;

	void Start () {
		
		if(PlayerPrefsX.GetBool ("vibrate", true)){
			
			tog.isOn = true;
		}
		else
		{
			
			tog.isOn = false;
		}
	}
	
	
	public void OnToggleChanged () {
		
		vibrate = !vibrate;
		
	}
	
	void Update (){
		
		if(vibrate == true){
			
			PlayerPrefsX.SetBool ("vibrate", false);
		}
		
		if(vibrate == false){
			
			PlayerPrefsX.SetBool ("vibrate", true);
		}
	}
}
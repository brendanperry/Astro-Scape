using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shipToggle : MonoBehaviour {

	public bool toggle;
	public Toggle tgl;

	public string ship;
	
	void Awake (){}
	
	void Start () {
		
		if(PlayerPrefsX.GetBool (ship, true)){
			
			tgl.isOn = true;
		}
		else
		{
			
			tgl.isOn = false;
		}
	}
	
	
	public void OnValueChanged () {
		
		toggle = !toggle;
		
	}
	
	void Update (){
		
		if(toggle == true){
			
			PlayerPrefsX.SetBool (ship, true);
		}
		
		if(toggle == false){
			
			PlayerPrefsX.SetBool (ship, false);
		}
	}
}
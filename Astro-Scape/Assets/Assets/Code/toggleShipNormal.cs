using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggleShipNormal : MonoBehaviour {

	public bool toggle;
	public Toggle tgl;
	
	public string whatBool;
	
	void Awake (){}
	
	void Start () {
		
		if(PlayerPrefsX.GetBool (whatBool, true)){
			
			tgl.isOn = true;
		}
		else
		{
			
			tgl.isOn = false;
		}
	}
	
	
	public void OnToggleChanged () {
		
		toggle = !toggle;
		
	}
	
	void Update (){
		
		if(toggle == true){
			
			PlayerPrefsX.SetBool (whatBool, false);
		}
		
		if(toggle == false){
			
			PlayerPrefsX.SetBool (whatBool, true);
		}
	}
}
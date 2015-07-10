using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class StorePrefs : MonoBehaviour {

	GameObject[] buttons;
	ButtonToggle b;

	void Awake(){

		buttons = GameObject.FindGameObjectsWithTag("practice_button");

	}

	public void StoreProfile(){

		string profileString = "";
		List<string> profiles = new List<string>();

		for( int i = 0; i < buttons.Length; i++ ){
			b = buttons[i].GetComponent<ButtonToggle>();
			if( b.isOn() ){
				profiles.Add (b.profile);
			}
		}
		if(profiles.Count < 1){
			profileString = "control";
		}else{
			profileString = String.Join( "," , profiles.ToArray() );
		}

		PlayerPrefs.SetString( "customProfile", profileString );
	}
}

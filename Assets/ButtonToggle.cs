using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonToggle : MonoBehaviour {

	public string profile;
	bool on = false;

	ProfileComponent player;
	GameObject[] buttons;
	Image img;
	ButtonToggle tempButton;

	// Use this for initialization
	void Awake () {

		player = GameObject.FindGameObjectWithTag("Player").GetComponent<ProfileComponent>();
		buttons = GameObject.FindGameObjectsWithTag("practice_button");
		img = GetComponent<Image>();
	
	}
	
	public void Toggle(){

		on = !on;

		if(on){

			AddProfile();
			//color button
			img.fillCenter = true;

		}else{

			player.loadProfile("control");
			for(int i = 0; i < buttons.Length; i++){
				tempButton = buttons[i].GetComponent<ButtonToggle>();
				if( tempButton.isOn() ){
					tempButton.AddProfile();
				}
			}

			//uncolor button
			img.fillCenter = false;
		}

	}

	public void AddProfile(){

		player.loadProfile_Add(profile);

	}

	public bool isOn(){
		return on;
	}
}

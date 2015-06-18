using UnityEngine;
using System.Collections;

public class AudioPitch : PresentationObject {

	private Transform m_Transform;
	public bool distance_input;
	public bool direction_input;

	// Use this for initialization
	void Start () {
		Subscribe ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float get_pitch(){
		float pitch = 2.0f;

		if (distance_input) {
			//modulate pitch based on distance

//			pitch = 2.0f - distance / 20;
			if (pitch < .12f) {
				pitch = .12f;
			}
		} else if (direction_input){
			//modulate pitch based on direction
//			pitch = 2.0f - Mathf.Abs(direction) / 180;
			if (pitch < .12f) {
				pitch = .12f;
			}
		}
	
		return pitch;
	}
}

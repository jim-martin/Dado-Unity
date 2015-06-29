using UnityEngine;
using System.Collections;
using Data;

public class AudioPitch : MonoBehaviour {
	
	public bool distance_input;
	public bool direction_input;
	DataComponent data;

	// Use this for initialization
	void Start () {
		data = GetComponent<DataComponent> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float get_pitch(){
		float pitch = 2.0f;

		if (distance_input) {
			//modulate pitch based on distance

			pitch = 2.0f - data.getDistance() / 20;
			if (pitch < .12f) {
				pitch = .12f;
			}
		} else if (direction_input){
			//modulate pitch based on direction
			pitch = 2.0f - Mathf.Abs(data.getDirection()) / 180;
			if (pitch < .12f) {
				pitch = .12f;
			}
		}
	
		return pitch;
	}

	public float get_pitch(GameObject go){
		float pitch = 2.0f;
		
		if (distance_input) {
			//modulate pitch based on distance
			
			pitch = 2.0f - data.getDistance(go) / 20;
			if (pitch < .12f) {
				pitch = .12f;
			}
		} else if (direction_input){
			//modulate pitch based on direction
			pitch = 2.0f - Mathf.Abs(data.getDirection(go)) / 180;
			if (pitch < .12f) {
				pitch = .12f;
			}
		}
		
		return pitch;
	}
}

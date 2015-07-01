using UnityEngine;
using System.Collections;
using Data;

public class AudioPitch : MonoBehaviour {
	
	public bool distance_input;
	public bool direction_input;
	public bool zAxis_input;
	public float minimumPitchScale;
	public float maximumPitchScale;

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

		if (maximumPitchScale != null) {
			pitch = maximumPitchScale;
		}

		if (distance_input) {
			//modulate pitch based on distance

			pitch = pitch - data.getDistance() / 20;
			//could use better calibration for distance - how far do we anticipate the maximum distance being?

		} else if (direction_input){
			//modulate pitch based on direction
			pitch = 2.0f - Mathf.Abs(data.getDirection()) / 180;
		}

		if (pitch < .12f) {
			pitch = .12f;
		}
		if(pitch < minimumPitchScale){
			pitch = minimumPitchScale;
		}

		//have pitch modulate up or down while playing in relation to change in distance
	
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

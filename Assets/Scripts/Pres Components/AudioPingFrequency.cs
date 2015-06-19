using UnityEngine;
using System.Collections;

public class AudioPingFrequency : PresentationObject {
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

	public float get_interval(){
		float interval = 1;

		Debug.Log (dataInput);

		if (distance_input == true) {
			float distance = dataInput [0];
			Debug.Log (distance);
			interval = distance / 50;
		} else if (direction_input == true) {

		} 

			if (interval < .1f) {
				interval = .1f;
			}
		Debug.Log ("audio ping frequency:");
		Debug.Log (interval);
			return interval;
	}
}

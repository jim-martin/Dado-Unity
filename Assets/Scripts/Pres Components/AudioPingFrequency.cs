using UnityEngine;
using System.Collections;
using Data;

public class AudioPingFrequency : MonoBehaviour {
//	private Transform m_Transform;
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

	public float get_interval(){
		float interval = 1;

		if (distance_input == true) {
			float distance = data.getDistance();
			interval = distance / 50;
		} else if (direction_input == true) {
			float direction = data.getDirection();
			interval = Mathf.Abs(direction) / 60;
		} 

			if (interval < .1f) {
				interval = .1f;
			}

		return interval;
	}
}

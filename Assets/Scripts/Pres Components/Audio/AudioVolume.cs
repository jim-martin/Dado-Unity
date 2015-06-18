using UnityEngine;
using System.Collections;
using Data;

public class AudioVolume : MonoBehaviour {
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
	
	public float get_volume(){
		float volume = 1;

		if (distance_input == true) {
			volume = 1.0f - data.getDistance () / 50;
		} else if (direction_input == true) {
			//this doesn't really make sense
		}

		Debug.Log (volume);
		return volume;

	}
}

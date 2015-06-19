using UnityEngine;
using System.Collections;
using Data;

public class AudioPanning : MonoBehaviour {
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
	
	public float get_panning(){
		float panning = 0;
		
		if (distance_input == true) {
//			volume = 1.0f - data.getDistance () / 50;
			//distance doesn't make sense for panning
		} else if (direction_input == true) {
			float angleRadians = data.getDirection() * Mathf.PI / 180;
			panning = -1 * Mathf.Sin (angleRadians);
		}
		
		Debug.Log (panning);
		return panning;
	}

	public Vector3 get_target_location(){
		return data.getGlobalPosition ();
	}
}

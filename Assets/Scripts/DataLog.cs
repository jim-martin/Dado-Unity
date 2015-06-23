using UnityEngine;
using System;
using System.Collections;
using Data;

public class DataLog : MonoBehaviour {

	DataComponent data;

		public bool globalPos = true;
		public bool relativePos = true;
		public bool distance = true;
		public bool direction = true;

	void Start () {
		data = GetComponent<DataComponent> ();
	}

	void Update () {

		if (globalPos) {
			Vector3 v = data.getGlobalPosition();
			Debug.Log ("globalPos : " + v);
		}

		if (relativePos) {
			Vector3 v = data.getRelativePosition();
			Debug.Log ("relativePos : " + v);
		}

		if (distance) {
			float v = data.getDistance();
			Debug.Log ("distance : " + v);
		}

		if (direction) {
			float v = data.getDirection();
			Debug.Log ("direction : " + v);
		}
	
	}
}

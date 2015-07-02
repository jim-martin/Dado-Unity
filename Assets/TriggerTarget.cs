using UnityEngine;
using System.Collections;

public class TriggerTarget : MonoBehaviour {

	public bool isTriggered = false;


	void OnCollisionEnter( Collision col ){

		if (col.gameObject.tag == "push") {
			isTriggered = true;
		}

	}
}

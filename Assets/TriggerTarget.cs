using UnityEngine;
using System.Collections;

public class TriggerTarget : MonoBehaviour {

	public bool isTriggered = false;

	void OnCollisionEnter( Collision col ){

		MeshRenderer mesh = GetComponent<MeshRenderer> ();

		if (col.gameObject.tag == "push" && mesh.enabled) {
			isTriggered = true;
		}

	}
}

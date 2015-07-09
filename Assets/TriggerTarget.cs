using UnityEngine;
using System.Collections;

public class TriggerTarget : MonoBehaviour {

	public bool isTriggered = false;

	MeshRenderer mesh;

	void Awake (){
		mesh = GetComponent<MeshRenderer> ();
	}

	void OnCollisionEnter( Collision col ){

		if (col.gameObject.tag == "push" && mesh.enabled) {
			isTriggered = true;
		}

	}

	void OnTriggerEnter( Collider other ){

		if (other.gameObject.tag == "Player" && mesh.enabled) {
			isTriggered = true;
		}
	}
}

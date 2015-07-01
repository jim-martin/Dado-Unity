using UnityEngine;
using System.Collections;

public class KickController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.E)) {
			GetComponent<Animator>().SetTrigger( "Trigger" );
		}
	
	}
}

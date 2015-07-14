using UnityEngine;
using System.Collections;

public class KickController : MonoBehaviour {

	Camera cam;

	// Use this for initialization
	void Start () {

		cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = cam.transform.rotation;

		if (Input.GetKeyDown (KeyCode.E)) {
			GetComponent<Animator>().SetTrigger( "Trigger" );
		}
	
	}
}

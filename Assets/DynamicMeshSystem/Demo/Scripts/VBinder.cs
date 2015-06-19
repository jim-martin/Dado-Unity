using UnityEngine;
using System.Collections;

public class VBinder : MonoBehaviour {
	public GameObject Target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Target)
		Target.transform.position = transform.position;
	}
}

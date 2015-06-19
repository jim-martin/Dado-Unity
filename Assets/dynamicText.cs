using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Data;
using System.Collections;
using System.Collections.Generic;

public class dynamicText : MonoBehaviour {
	Text text;  

	// Use this for initialization
	void Start () {
		// Set up the reference.
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] players = getPlayers ();
			foreach (GameObject p in players) {
		text.text = "Score";
	}
}


using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Data;

public class canvasDynamics : MonoBehaviour {

	DataComponent data;
	Canvas canvas;
	Text text;  

	private float distance;
	private float direction;

	// Use this for initialization
	void Start () {
		data = GetComponent<DataComponent> ();
		canvas = GetComponent<Canvas> ();
		Debug.Log (canvas);
		//text = GetComponent<Text> ();\
		GameObject textContainer = GameObject.Find("dynamicText");
		text = textContainer.GetComponent<Text> ();
		Debug.Log( text );

	//	text = GameObject.Find("dynamicText");
	
	}
	
	// Update is called once per frame
	void Update () {
		distance =  data.getDistance();
		direction = data.getDirection();
		text.text = "distance: " + distance;
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Data;

public class canvasDynamics : MonoBehaviour {

	public float Map(float from, float to, float from2, float to2, float value){
		if(value <= from2){
			return from;
		}else if(value >= to2){
			return to;
		}else{
			return (to - from) * ((value - from2) / (to2 - from2)) + from;
		}

	}

	DataComponent data;
	Canvas canvas;
	Text text;  
	Image hotOrColdImage;
	AudioPitch audioPitchObject;
	/*private GameObject character;
	  bool change;*/
	private GameObject teammate;
	private GameObject radar;
	private GameObject playerAxis;
	private GameObject hotOrCold;

	private float distance;
	private float direction;
	private float hudRadius;
	private float proximityToTeammate = 187; // Almost all of radar radius
	private float maxDistanceFromTeammate = 40;
	private float prevDistance;
	private float maxPlayerArrowSize = 4;

	public bool hotWarmDot;
	public bool textToggle;
	public bool distanceTextToggle;
	public bool coldOrHotTextToggle;
	public bool scaleTargetArrowWithDistance;

	// Use this for initialization
	void Start () {
		data = GetComponent<DataComponent> ();
		canvas = GetComponent<Canvas> ();
		//Debug.Log (canvas);
		//text = GetComponent<Text> ();\
		GameObject textContainer = GameObject.Find("dynamicText");
		teammate = GameObject.Find("teammate");
		radar = GameObject.Find("radar");
		//character = GameObject.Find("character");
		text = textContainer.GetComponent<Text> ();
		//Debug.Log( text );
		/*change = false;*/
	//	text = GameObject.Find("dynamicText");
		hudRadius = 200;
		prevDistance = data.getDistance();
		hotOrCold = GameObject.Find ("hotOrCold");
	//	Debug.LogWarning (hotOrCold);
		hotOrColdImage = hotOrCold.GetComponent<Image> ();
		Debug.Log (hotOrColdImage);

		// Toggling on and off
		if (hotWarmDot == true) {
			hotOrColdImage.enabled = true;
		} else {
			hotOrColdImage.enabled = false;
		}
		if (textToggle == true) {
			text.enabled = true;
		} else {
			text.enabled = false;
		}
		if (scaleTargetArrowWithDistance) {
		} else {
		}

	
	}
	
	// Update is called once per frame
	void Update () {
		distance =  data.getDistance();
		direction = data.getDirectionWithView();
		//Debug.Log (data.getGlobalPosition ());
		//Debug.Log (direction);
		if (distanceTextToggle == true) {
			text.text = "Distance: " + distance;
		}
		if (distance > prevDistance) {
			//Debug.Log ("colder");
			if(coldOrHotTextToggle == true) {
				text.text = "colder";
			}
			hotOrColdImage.color = new Color32(255, 0, 0, 255);
		} else {
			//Debug.Log ("warmer");
			if(coldOrHotTextToggle == true) {
				text.text = "warmer";
			}
			prevDistance = distance;
			hotOrColdImage.color = new Color32(0, 255, 0, 255);
		}
		//Debug.Log ("Distance: " + data.getDistance () + " prevDistance: " + prevDistance);
		float difference = distance - prevDistance;
		//Debug.Log ("Difference: " + difference);
		if (distance - prevDistance > 2) {
			prevDistance = distance;
		}
		/*if (change == true) {
			character.transform.position = new Vector3 (character.transform.position.x + 2, character.transform.position.y, character.transform.position.z);
			change = false;
		} else {
			character.transform.position = new Vector3 (character.transform.position.x - 2, character.transform.position.y, character.transform.position.z);
			change = true;
		}*/

		// RADAR CODE
		/*
		 * Trigonometry stuff to rotate teammate
		float y = Mathf.Sin (direction) * hudRadius;
		float x = Mathf.Cos (direction) * hudRadius;
		teammate.transform.position = new Vector3 (x, y, teammate.transform.position.z);
		Debug.Log ("y: " + teammate.transform.position.y);
		Debug.Log ("x: " + teammate.transform.position.x);
		*/
		//float scale = Map (maxDistanceFromTeammate, 1, 4, 1, maxDistanceFromTeammate - distance);
		float scaleBy = (maxDistanceFromTeammate - distance) * maxPlayerArrowSize / maxDistanceFromTeammate;
		radar.transform.localEulerAngles = new Vector3 (0.0f, 0.0f, direction);
		if (scaleTargetArrowWithDistance) {
			//Debug.Log ("SCALE: " + scaleBy);
			teammate.transform.localScale = new Vector3 (scaleBy, scaleBy, 0);
		}
		//teammate.transform.position = new Vector3 (teammate.transform.position.x, proximityToTeammate*0.003292852f, teammate.transform.position.z);
		//radar.transform.Rotate (0, 0, direction);
	}
}

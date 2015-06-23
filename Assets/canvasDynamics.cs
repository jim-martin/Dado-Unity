using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Data;

public class canvasDynamics : MonoBehaviour {

	DataComponent data;
	Canvas canvas;
	Text text;  
	Image hotOrColdImage;
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

	// Use this for initialization
	void Start () {
		data = GetComponent<DataComponent> ();
		canvas = GetComponent<Canvas> ();
		//Debug.Log (canvas);
		//text = GetComponent<Text> ();\
		GameObject textContainer = GameObject.Find("dynamicText");
		teammate = GameObject.Find("teammate");
		radar = GameObject.Find("radar");
		playerAxis = GameObject.Find ("OVRCameraRig 1");
		//character = GameObject.Find("character");
		text = textContainer.GetComponent<Text> ();
		//Debug.Log( text );
		/*change = false;*/
	//	text = GameObject.Find("dynamicText");
		hudRadius = 200;
		prevDistance = data.getDistance();
		hotOrCold = GameObject.Find ("hotOrCold");
		hotOrColdImage = hotOrCold.GetComponent<Image> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		distance =  data.getDistance();
		direction = data.getDirection();
		Debug.Log (data.getGlobalPosition ());
		Debug.Log (direction);
		//text.text = "direction: " + direction + " distance: " + distance;
		if (distance > prevDistance) {
			//Debug.Log ("colder");
			text.text = "colder";
			hotOrColdImage.color = new Color32(255, 0, 0, 255);
		} else {
			//Debug.Log ("warmer");
			text.text = "warmer";
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
		proximityToTeammate = (distance * hudRadius) / maxDistanceFromTeammate;
		//Debug.Log (playerAxis.transform.eulerAngles.y);
		radar.transform.eulerAngles = new Vector3 (radar.transform.eulerAngles.x, radar.transform.eulerAngles.y, direction);
		//teammate.transform.position = new Vector3 (teammate.transform.position.x, proximityToTeammate*0.003292852f, teammate.transform.position.z);
		//radar.transform.Rotate (0, 0, direction);
	}
}

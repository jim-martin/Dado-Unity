using UnityEngine;
using System.Collections.Generic;

public class AudioComponent : MonoBehaviour {

	private TeamDataController t_data;
	private Vector3[] people;
	public AudioClip c_0;
	public AudioClip c_50;
	public AudioClip c_100;
	private Transform m_Transform;
	private AudioSource ping;

	// Use this for initialization
	void Start () {
		//get team data
		t_data = GetComponent<TeamDataController>();
		people = t_data.DirectionVectors ();
		m_Transform = GetComponent<Transform> ();
		ping = GetComponent<AudioSource> ();
		ping.spatialBlend = 1;
		ping.minDistance = 1;
		ping.maxDistance = 100;

		InvokeRepeating ("location_ping", 2, 1);
	

		//initialize oscillators?

	}
	
	// Update is called once per frame
	void Update () {
//		people = t_data.DirectionVectors ();


		//rotate by direction of person facing


//		AudioSource.PlayClipAtPoint (ping, people[1]);


	}

	void location_ping(){
		people = t_data.DirectionVectors ();
		Debug.Log (people.Length + " players found");
		Debug.Log (people [0]);

//		for (int i = 0; i < people.Length; i++) {
//			Debug.Log (people[i]);
//		}



		Vector3 ping_location = new Vector3 (1000, 0, 0);
//		try{
//			Debug.Log (people [1]);
//			AudioSource.PlayClipAtPoint (c_0, ping_location);
//		}
//		catch(UnityException e){
//			Debug.Log (e);
//		}

		float distance = Vector3.Distance(people[0], m_Transform.position);

		Vector3 targetDir = people[0] - m_Transform.position;
		Vector3 forward = m_Transform.forward;

//		Debug.Log (targetDir);
//		Debug.Log (forward);

		float angle = Vector3.Angle(targetDir, forward);
		int angleDir = 0;
		if (Vector3.Cross (targetDir, forward).y > 0) {
			angleDir = 1; //looking to the right of the target, pan to the left
		} else {
			angleDir = 0; //looking to the left of the target, pan to the right
		}
		Debug.Log (angleDir);
		Debug.Log (angle);

		float angleRadians = angle * Mathf.PI / 180;

		//pan by the sin(angle)
		float panAmount = Mathf.Sin (angleRadians);
		if (angleDir != 0) {
			panAmount = panAmount * -1;
		}
		Debug.Log (panAmount);
		ping.panStereo = panAmount;
		ping.panStereo = 1;

		ping.pitch = 2.0f - distance / 20;
		if (ping.pitch < .12f) {
			ping.pitch = .12f;
		}

		Debug.Log (distance);
		if (distance < 10) {
			Debug.Log ("near");
//			AudioSource.PlayClipAtPoint (c_0, ping_location);
			ping.volume = 1;
		} else if (distance < 50) {
			Debug.Log ("middle");
//			AudioSource.PlayClipAtPoint (c_50, ping_location);
//			ping.volume = 0.5f;
			ping.volume = 1.0f - distance / 50;
		}
		else{
			Debug.Log ("far");
//			AudioSource.PlayClipAtPoint (c_100, ping_location);
			ping.volume = 0.1f;
		}

		ping.Play ();

	}

	//create tone
	//set frequency
}

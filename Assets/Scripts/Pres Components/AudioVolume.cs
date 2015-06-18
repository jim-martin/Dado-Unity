using UnityEngine;
using System.Collections;

public class AudioVolume : PresentationObject {

	private Transform m_Transform;
	private AudioSource ping;
	
	void Start () {
		//subscribe to data feed
		Subscribe ();

		ping = GetComponent<AudioSource> ();
		ping.spatialBlend = 1;
		ping.minDistance = 1;
		ping.maxDistance = 100;
		
		InvokeRepeating ("location_ping", 2, 1);

	}

	void location_ping(){
		float distance = dataInput [0];

		if (distance != null ) {
			distance = Mathf.Abs (distance);
		}

		Debug.Log (distance);
		if (distance < 10) {
			ping.volume = 1;
		} else if (distance < 50) {
			ping.volume = 1.0f - distance / 50;
		}
		else{
			ping.volume = 0.2f;
		}

		float pitch = 2.5f;
		if (distance > 100.0f) {
			pitch = 0.5f;
		} else {
			pitch = 2.5f - distance / 30;
		}

		ping.pitch = pitch;
		if (ping.pitch < 0) {
			ping.pitch = 0;
		}
		
		ping.Play ();
		
	}
}

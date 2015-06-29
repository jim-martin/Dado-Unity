using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

public class AudioComponent : MonoBehaviour {
	private AudioSource ping;
	private float interval;
	private AudioPingFrequency audio_ping_frequency;
	private AudioPitch audio_pitch;
	private AudioVolume audio_volume;
	private AudioPanning audio_panning;
	private DataComponent data;
	
	void Start () {
		audio_ping_frequency = GetComponent<AudioPingFrequency> ();
		audio_pitch = GetComponent<AudioPitch> ();
		audio_volume = GetComponent<AudioVolume> ();
		audio_panning = GetComponent<AudioPanning> ();

		data = GetComponent<DataComponent> ();

		ping = GetComponent<AudioSource> ();
		ping.spatialBlend = 0;
		ping.minDistance = 1;
		ping.maxDistance = 100;

		interval = 1;
//		Invoke ("location_ping", interval);
		Invoke ("team_location_ping", 2);
	}
	
	// Update is called once per frame
	void Update () {
	}

	//find target
	void location_ping(){

		//set ping frequency
		if (audio_ping_frequency != null) {
			interval = audio_ping_frequency.get_interval();
			Debug.Log ("frequency = ");
			Debug.Log (interval);
		} else {
			Debug.Log ("Audio Ping Frequency is disabled");
			interval = 1;
		}

		//set pitch
		if (audio_pitch != null) {
			ping.pitch = audio_pitch.get_pitch();
		} else {
			ping.pitch = 1;
		}

		//set volume
		if (audio_volume != null) {
			ping.volume = audio_volume.get_volume();
		} else {
			ping.volume = 1;
		}

		//set panning
		if (audio_panning != null) {
//			AudioSource.PlayClipAtPoint(ping.clip, audio_panning.get_target_location());
			ping.panStereo = audio_panning.get_panning();
		} else {

		}

		ping.Play ();

		Invoke ("location_ping", interval);
	}

	//accept a GameObject target and pass it through to the recipes
	void location_ping(GameObject target){
		//frequency not included in this since it will be controlled by team_location_ping()

		//set pitch
		if (audio_pitch != null) {
			ping.pitch = audio_pitch.get_pitch(target);
		} else {
			ping.pitch = 1;
		}
		
		//set volume
		if (audio_volume != null) {
			ping.volume = audio_volume.get_volume(target);
		} else {
			ping.volume = 1;
		}
		
		//set panning
		if (audio_panning != null) {
			//			AudioSource.PlayClipAtPoint(ping.clip, audio_panning.get_target_location());
			ping.panStereo = audio_panning.get_panning(target);
		} else {
			
		}
		
		ping.Play ();
	}

	//ping around in a sonar fashion
	void team_location_ping(){
		//get team objects
		GameObject[] gos = data.getTeam ();

		//for each team object
		for (int i = 0; i < gos.Length; i++) {
			//get angle around
			float direction = data.getDirection (gos[i]);
			Debug.Log (direction);



			//-1 = 0
			//-180 or 180 = 1
			//1 = 2
			float time_interval = 0f;
			if(direction < 0){
				time_interval = Mathf.Abs (direction) / 180;
			}
			else if(direction > 0){
				time_interval = 1f;
				time_interval = 1f + (1 - Mathf.Abs (direction) / 180);
			}

			//start coroutine instead of using invoke
			StartCoroutine(PingWithObject(gos[i], time_interval));
//			invoke location_ping(myTeammate, time_interval)
		}


		Invoke("team_location_ping", 3);
	}
			              
	IEnumerator PingWithObject(GameObject go, float time_interval){
				yield return new WaitForSeconds (time_interval);
				location_ping (go);
	}
}

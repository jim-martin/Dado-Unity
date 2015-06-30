using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

public class AudioComponent : MonoBehaviour {
	private AudioSource ping;
	private AudioSource team1;
	private AudioSource team2;
	private AudioSource team3;
	private float interval;
	private AudioPingFrequency audio_ping_frequency;
	private AudioPitch audio_pitch;
	private AudioVolume audio_volume;
	private AudioPanning audio_panning;
	private DataComponent data;

	public bool target_search;
	public bool team_sonar;
	
	void Start () {
		audio_ping_frequency = GetComponent<AudioPingFrequency> ();
		audio_pitch = GetComponent<AudioPitch> ();
		audio_volume = GetComponent<AudioVolume> ();
		audio_panning = GetComponent<AudioPanning> ();

		data = GetComponent<DataComponent> ();

		AudioSource[] audio_sources = GetComponents<AudioSource> ();

		ping = audio_sources [0];
		team1 = audio_sources [1];
		team2 = audio_sources [2];
		team3 = audio_sources [3];
		ping.spatialBlend = 0;
		ping.minDistance = 1;
		ping.maxDistance = 100;

		interval = 1;

		if (target_search) {
			Invoke ("location_ping", interval);
		}

		if (team_sonar) {
			Invoke ("team_location_ping", 2);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//check if audio is playing

		//get time sample

		//adjust parameters

		//adjust pitch based on rate of change in distance

		//adjust panning in rate of change in direction


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
	void location_ping(GameObject target, int team_index){
		//frequency not included in this since it will be controlled by team_location_ping()

		AudioSource myPing = ping;
		switch (team_index) {
		case 0:
			myPing = ping;
			break;
		case 1:
			myPing = team1;
			break;
		case 2:
			myPing = team2;
			break;
		case 3:
			myPing = team3;
			break;
		default:
			myPing = ping;
			break;
		}

		//set pitch
		if (audio_pitch != null) {
			myPing.pitch = audio_pitch.get_pitch(target);
		} else {
			myPing.pitch = 1;
		}
		
		//set volume
		if (audio_volume != null) {
			myPing.volume = audio_volume.get_volume(target);
		} else {
			myPing.volume = 1;
		}
		
		//set panning
		if (audio_panning != null) {
			//			AudioSource.PlayClipAtPoint(ping.clip, audio_panning.get_target_location());
			myPing.panStereo = audio_panning.get_panning(target);
		} else {
			
		}
		
		myPing.Play ();
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



			//-1 -> 0s
			//-180 or 180 -> 1s
			//1 -> 2s
			float time_interval = 0f;
			if(direction < 0){
				time_interval = Mathf.Abs (direction) / 180;
			}
			else if(direction > 0){
				time_interval = 1f;
				time_interval = 1f + (1 - Mathf.Abs (direction) / 180);
			}

			//start coroutine instead of using invoke
			StartCoroutine(PingWithObject(gos[i], time_interval, i));
//			invoke location_ping(myTeammate, time_interval)
		}

		Invoke("team_location_ping", 3);
	}
			              
	IEnumerator PingWithObject(GameObject go, float time_interval, int team_index){
				yield return new WaitForSeconds (time_interval);
				location_ping (go, team_index);

		//this needs multiple sound sources to play overlapping
	}
}

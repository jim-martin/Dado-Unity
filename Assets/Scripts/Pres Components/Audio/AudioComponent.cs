using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

public class AudioComponent : MonoBehaviour
{
	private AudioSource ping;
	private AudioSource team1;
	private AudioSource team2;
	private AudioSource team3;
	private AudioSource me_ping;
	private float interval;
	private AudioPingFrequency audio_ping_frequency;
	private AudioPitch audio_pitch;
	private AudioVolume audio_volume;
	private AudioPanning audio_panning;
	private DataComponent data;
	private Transform myTransform;
	private HistoricalData historical_data;
	public bool target_search;
	public bool team_sonar;
	public bool self_ping;
	public bool historical_ping_toggle;
	public float total_interval;
	private bool pinging = false;
	public bool historical_binary;
	
	void Start ()
	{
		audio_ping_frequency = GetComponent<AudioPingFrequency> ();
		audio_pitch = GetComponent<AudioPitch> ();
		audio_volume = GetComponent<AudioVolume> ();
		audio_panning = GetComponent<AudioPanning> ();

		data = GetComponent<DataComponent> ();
		historical_data = GetComponent<HistoricalData> ();
		myTransform = GetComponent<Transform> ();

		AudioSource[] audio_sources = GetComponents<AudioSource> ();

		ping = audio_sources [0];
//		Debug.Log (ping);
		team1 = audio_sources [1];
		team2 = audio_sources [2];
		team3 = audio_sources [3];
		me_ping = audio_sources [4];
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

		if (historical_ping_toggle) {
			Invoke ("historical_ping", 2);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (target_search && !pinging) {
			Invoke ("location_ping", interval);
			pinging = true;
		}
		
		if (team_sonar && !pinging) {
			Invoke ("team_location_ping", 2);
			pinging = true;
		}
		
		if (historical_ping_toggle && !pinging) {
			Invoke ("historical_ping", 2);
			pinging = true;
		}
		//ping.Play ();
		//check if audio is playing

		//get time sample
		//adjust parameters

		//adjust pitch based on rate of change in distance
		//adjust panning in rate of change in direction


	}

	//find target
	void location_ping ()
	{
		Debug.Log ("calling location_ping");
		//set ping frequency
		if (audio_ping_frequency != null) {
			interval = audio_ping_frequency.get_interval ();
//			Debug.Log ("frequency = ");
//			Debug.Log (interval);
		} else {
			Debug.Log ("Audio Ping Frequency is disabled");
			interval = 1;
		}

		//set pitch
		if (audio_pitch != null) {
			ping.pitch = audio_pitch.get_pitch ();
		} else {
			ping.pitch = 1;
		}

		//set volume
		if (audio_volume != null) {
			ping.volume = audio_volume.get_volume ();
		} else {
			ping.volume = 1;
		}

		//set panning
		if (audio_panning != null) {
//			AudioSource.PlayClipAtPoint(ping.clip, audio_panning.get_target_location());
			ping.panStereo = audio_panning.get_panning ();
		} else {

		}

		ping.Play ();

		Invoke ("location_ping", interval);
	}


	//ping around in a sonar fashion
	void team_location_ping ()
	{
		//get team objects
		GameObject[] gos = data.getTeam ();

		if (total_interval == null) {
			total_interval = 1f;
		}

		//for each team object
		for (int i = 0; i < gos.Length; i++) {
			//get angle around
			float direction = data.getDirection (gos [i]);
			Debug.Log (direction);



			//-1 -> 0s
			//-180 or 180 -> 1s
			//1 -> 2s
			float time_interval = 0f;
			if (direction < 0) {
				time_interval = Mathf.Abs (direction) / 180 * total_interval / 2;
			} else if (direction > 0) {
				time_interval = total_interval / 2;
				time_interval = (total_interval / 2) + ((total_interval / 2) - Mathf.Abs (direction) / 180 * (total_interval / 2));
			}

			//start coroutine instead of using invoke
			StartCoroutine (PingWithObject (gos [i], time_interval, i));
//			invoke location_ping(myTeammate, time_interval)
		}

		float reinvoke_interval = total_interval;

		if (self_ping == true) {
			me_ping.Play ();
		}

		Invoke ("team_location_ping", reinvoke_interval);
	}
			              
	IEnumerator PingWithObject (GameObject go, float time_interval, int team_index)
	{
		yield return new WaitForSeconds (time_interval);
		location_ping (go, team_index);

		//this needs multiple sound sources to play overlapping
	}
	//accept a GameObject target and pass it through to the recipes
	//used for team location ping
	void location_ping (GameObject target, int team_index)
	{
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
			myPing.pitch = audio_pitch.get_pitch (target);
		} else {
			myPing.pitch = 1;
		}
		
		//set volume
		if (audio_volume != null) {
			myPing.volume = audio_volume.get_volume (target);
		} else {
			myPing.volume = 1;
		}
		
		//set panning
		if (audio_panning != null) {
			//			AudioSource.PlayClipAtPoint(ping.clip, audio_panning.get_target_location());
			myPing.panStereo = audio_panning.get_panning (target);
		} else {
			
		}
		
		myPing.Play ();
	}


	IEnumerator PingWithMarker (Marker go, float time_interval, int team_index)
	{
		yield return new WaitForSeconds (time_interval);
		location_ping (go, team_index);
		
		//this needs multiple sound sources to play overlapping
	}

	//accept a GameObject target and pass it through to the recipes
	//used for team location ping
	void location_ping (Marker target, int team_index)
	{
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
//			myPing.pitch = audio_pitch.get_pitch (target);
			myPing.pitch = 1;
		} else {
			myPing.pitch = 1;
		}
		
		//set volume
		if (audio_volume != null) {
			myPing.volume = audio_volume.get_volume (target);
		} else {
			myPing.volume = 1;
		}
		
		//set panning
		if (audio_panning != null) {
			//			AudioSource.PlayClipAtPoint(ping.clip, audio_panning.get_target_location());
			myPing.panStereo = audio_panning.get_panning (target);
		} else {
			
		}
		
		myPing.Play ();
	}


	List<Marker> concatenateTrails( GameObject[] trails ){

		//create return list
		List<Marker> r = new List<Marker>();

		//concat each array into return list
		for(int i = 0; i < trails.Length; i++){
			try{
				r.AddRange(trails[i].GetComponent<FollowMarkerComponent>().GetTrail());
			}catch(UnityException e){
				Debug.Log("Trail at " + trails[i].name + " isn't providing a marker list.");
			}
		}

		//return the list
		return r;
	}



	void historical_ping ()
	{
		//get my location
		Vector3 myPos = myTransform.position;

		float interval = 1f;

		float freshness = 0f;

		//get teammates
		GameObject[] gos = data.getTeam ();

		GameObject[] trails = GameObject.FindGameObjectsWithTag("TeamTrail");
		List<Marker> historical_trail = concatenateTrails( trails );

		List<Marker> close_markers_list = new List<Marker> ();

		if (historical_trail.Count > 0) {

			int close_markers = 0;
			float most_recent = 0;

			float first_timestamp = historical_trail[0].timeCreated;
			float last_timestamp = historical_trail[0].timeCreated;

			foreach (Marker mark in historical_trail) {
				//check which ones are within the bounding radius
//				Debug.Log (mark);
				float dist = Vector3.Distance (myPos, mark.position);
//				Debug.Log (dist);

				if(mark.timeCreated < first_timestamp){
					first_timestamp = mark.timeCreated;
				}
				if(mark.timeCreated > last_timestamp){
					last_timestamp = mark.timeCreated;
				}

//				Debug.Log ("my Y: "+myPos.y);
//				Debug.Log ("marker Y: "+mark.position.y);
				if (dist < 3 && (Mathf.Abs (Mathf.Abs (myPos.y) - Mathf.Abs (mark.position.y)) < 2)) {//check for z-axis distance

					close_markers_list.Add(mark);

					//set ping frequency relative to number of markers
					//update time spent
					close_markers++;
				
					//update freshness
					if (mark.timeCreated > most_recent) {
						most_recent = mark.timeCreated;
					}



				}
			}
			if (close_markers > 0) {
				//set ping frequency




				//set pitch
				if(historical_binary){
					ping.Play ();
					interval = 1f / close_markers;
					if(interval < .1f){
						interval = .1f;
					}
				}
				else{
					historical_sonar(close_markers_list);
				}
			}
		}


//		}
		//how do you deal with self data?

		//log freshness

		//log time spent

		Invoke ("historical_ping", interval);
	}

	void historical_sonar(List<Marker> markers){
		//for each team object
		float total_interval = 1f;

		for (int i = 0; i < markers.Count; i++) {
			//get angle around
			float direction = data.getDirection (markers [i]);
			Debug.Log (direction);
			
			
			
			//-1 -> 0s
			//-180 or 180 -> 1s
			//1 -> 2s
			float time_interval = 0f;
			if (direction < 0) {
				time_interval = Mathf.Abs (direction) / 180 * total_interval / 2;
			} else if (direction > 0) {
				time_interval = total_interval / 2;
				time_interval = (total_interval / 2) + ((total_interval / 2) - Mathf.Abs (direction) / 180 * (total_interval / 2));
			}


			//start coroutine instead of using invoke
			if(i == 0 || i == markers.Count - 1 || i == markers.Count / 2){
				Debug.Log ("historical pinging: "+i);
				StartCoroutine (PingWithMarker (markers [i], time_interval, i));
				//invoke location_ping(myTeammate, time_interval)
			}
		}
		
		float reinvoke_interval = total_interval;
		
		if (self_ping == true) {
			me_ping.Play ();
		}
	}

}

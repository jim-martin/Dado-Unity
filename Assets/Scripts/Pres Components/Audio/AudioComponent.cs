using UnityEngine;
using System.Collections.Generic;

public class AudioComponent : MonoBehaviour {
	private AudioSource ping;
	private float interval;
	private AudioPingFrequency audio_ping_frequency;
	private AudioPitch audio_pitch;
	private AudioVolume audio_volume;
	private AudioPanning audio_panning;
	
	void Start () {
		audio_ping_frequency = GetComponent<AudioPingFrequency> ();
		audio_pitch = GetComponent<AudioPitch> ();
		audio_volume = GetComponent<AudioVolume> ();
		audio_panning = GetComponent<AudioPanning> ();

		ping = GetComponent<AudioSource> ();
		ping.spatialBlend = 0;
		ping.minDistance = 1;
		ping.maxDistance = 100;

		interval = 1;
		Invoke ("location_ping", interval);

	}
	
	// Update is called once per frame
	void Update () {
	}

	void location_ping(){
		//set ping frequency
		if (audio_ping_frequency != null) {
			interval = audio_ping_frequency.get_interval();
//			Debug.Log ("frequency = ");
//			Debug.Log (interval);
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

	//takes an angle that it is currently at
	//can probably increment by 10 degrees?
	private int cur_loc = 0;
	void all_players_ping(){
		//reset
		if (cur_loc >= 360) {
			cur_loc = 0;
			Invoke("all_players_ping", 2);
		}
			
		//loop around in 360 degrees
		//if cur_loc > player_loc && player_loc == unpinged
			//ping_player(i)


		//call for the next 10 degrees
		cur_loc += 10;
		Invoke ("all_players_ping", .05f);
	}
}

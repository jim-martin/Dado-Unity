using UnityEngine;
using System.Collections;
using Data;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class HapticFrequency_Myo : MonoBehaviour {

	private AudioPingFrequency apf;
	private GameObject device;
	private ThalmicMyo thalmicMyo;
	private ThalmicHub hub;
	
	void Start () {
		apf = GetComponent<AudioPingFrequency> ();

		//init the myo
		device = GameObject.FindGameObjectWithTag ("Myo");
		thalmicMyo = device.GetComponent<ThalmicMyo> ();
		hub = ThalmicHub.instance;
		if (!hub.hubInitialized) {
			Debug.LogError ("Myo not initialized, disabling Myo feedback");
			this.enabled = false;
		}

		Invoke ("Vibrate", 2);
	}

	void Vibrate(){

		thalmicMyo.Vibrate (VibrationType.Short);

		float delay = apf.get_interval ();
		Invoke ("Vibrate", delay);

	}
}

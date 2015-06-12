using UnityEngine;
using System.Collections;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class MyoFeedbackController : MonoBehaviour {

	private GameObject myo;
	private ThalmicMyo thalmicMyo;

	// Use this for initialization
	void Start () {
		myo = GameObject.FindGameObjectWithTag ("Myo");
		thalmicMyo = myo.GetComponent<ThalmicMyo> ();	
	}

	public void Vibrate(){
		thalmicMyo.Vibrate (VibrationType.Medium);
	}
}

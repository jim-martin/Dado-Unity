using UnityEngine;
using System.Collections;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class HapticMyoPresentation : PresentationObject {
	
	public float lowDistanceThreshold = 5.0f;
	public float medDistanceThreshold = 10.0f;
	public float highDistanceThreshold = 15.0f;
		
	//Myo Objects
	private GameObject device;
	private ThalmicMyo thalmicMyo;
	private ThalmicHub hub = ThalmicHub.instance;
	
	
	void Start () 
	{
		//init the myo
		device = GameObject.FindGameObjectWithTag ("Myo");
		thalmicMyo = device.GetComponent<ThalmicMyo> ();
		if (!hub.hubInitialized) {
			Debug.LogError ("Myo not initialized, disabling Myo feedback");
			this.enabled = false;
		}
		
		InvokeRepeating ("CheckDistance", 5, 1);
		
	}

	void CheckDistance () 
	{
		float distance = 100.0f;
		
		foreach (float t in dataInput) {
			//find the nearest teammate's distance
			if( t < distance ){
				distance = t;
			}
		}
		
		//apply appropriate feedback
		if (distance < lowDistanceThreshold) {
			thalmicMyo.Vibrate (VibrationType.Short);
			return;
		}
		
		if (distance < medDistanceThreshold){
			thalmicMyo.Vibrate (VibrationType.Short);
			thalmicMyo.Vibrate (VibrationType.Short);
			return;
		}
		
		if (distance < highDistanceThreshold){
			thalmicMyo.Vibrate (VibrationType.Medium);
			return;
		}
		
		thalmicMyo.Vibrate (VibrationType.Long);		
	}
}

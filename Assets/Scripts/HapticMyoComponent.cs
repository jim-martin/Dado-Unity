using UnityEngine;
using System;
using System.Collections;
using DataComponents;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;


[RequireComponent(typeof (Transform))]
public class HapticMyoComponent : MonoBehaviour 
{

	public float lowDistanceThreshold = 5.0f;
	public float medDistanceThreshold = 10.0f;
	public float highDistanceThreshold = 15.0f;
	[HideInInspector] public int distState = 1;
	[HideInInspector] public int ddistState = 1;

	//Location objects
	private LocationData m_LocationData;
	private Transform m_Transform;

	//Myo Objects
	private GameObject device;
	private ThalmicMyo thalmicMyo;
	private ThalmicHub hub = ThalmicHub.instance;


	void Start () 
	{
		m_LocationData = new LocationData (this.gameObject);
		m_Transform = GetComponent<Transform> ();

		//init the myo
		device = GameObject.FindGameObjectWithTag ("Myo");
		thalmicMyo = device.GetComponent<ThalmicMyo> ();
		if (!hub.hubInitialized) {
			Debug.LogError ("Myo not initialized, disabling Myo feedback");
			this.enabled = false;
		}

	}

	void Update () 
	{
		distState = 4;
		float[] team = m_LocationData.getDistances ();

		foreach (float t in team) {
			//find the lowest distance threshhold for the current team member
			int tState;
			if( t < highDistanceThreshold  ){
				tState = 3;
			}else if( t < medDistanceThreshold ){
				tState = 2;
			}else if( t < lowDistanceThreshold ){
				tState = 1;
			}else{
				tState = 4;
			}

			//if it's lower than the previous (i.e. this user is closer), use that, otherwise ignore it.
			if( tState < distState ){
				distState = tState;
			}
		}
		Debug.Log (distState);
		//give appropriate feedback
		if (distState != ddistState) {

			Debug.LogWarning(distState);

			switch(distState)
			{
			case 1:
				thalmicMyo.Vibrate(VibrationType.Long);
				break;
			case 2:
				thalmicMyo.Vibrate(VibrationType.Medium);
				break;
			case 3:
				thalmicMyo.Vibrate(VibrationType.Short);
				break;
			case 4:
				break;
			}
			ddistState = distState;
		}
	}
}

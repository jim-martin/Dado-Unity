using UnityEngine;
using System;
using System.Collections.Generic;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

[RequireComponent(typeof (Transform))]
public class TeamDataController : MonoBehaviour 
{
	[Serializable]
	public class FeedbackSettings
	{
		[Serializable]
		public class Myo {
			public bool enabled = true;
			public float distanceThreshold = 5.0f;
			[HideInInspector] public Boolean distAlert = false;
			[HideInInspector] public Boolean ddistAlert = false;

			[HideInInspector] public GameObject device;
			[HideInInspector] public ThalmicMyo thalmicMyo;
			private ThalmicHub hub = ThalmicHub.instance;

			public void init(){
				device = GameObject.FindGameObjectWithTag ("Myo");
				thalmicMyo = device.GetComponent<ThalmicMyo> ();	
				if (!hub.hubInitialized) {
					Debug.LogError ("Myo not initialized, disabling Myo feedback");
					enabled = false;
				}
			}
		}
		public Myo myo = new Myo ();

		[Serializable]
		public class Audio {
			public bool enabled = true;
		}
		public Audio audio = new Audio ();
	}

	public FeedbackSettings feedback = new FeedbackSettings();

	private Transform m_Transform;
	private Vector3[] team;
	private PhotonView m_PhotonView;

	void Start()
	{
		m_Transform = GetComponent<Transform> ();
		m_PhotonView = GetComponent<PhotonView> ();

		feedback.myo.init ();
	}

	void Update()
	{
		feedback.myo.distAlert = false;
		team = DirectionVectors();
		foreach (Vector3 v in team) {
			if(v.magnitude > feedback.myo.distanceThreshold){
				feedback.myo.distAlert = true;
				Debug.DrawLine( m_Transform.position, m_Transform.position + v, Color.red, 2f );
			}else{
				Debug.DrawLine( m_Transform.position, m_Transform.position + v, Color.yellow, 2f );
			}
		}

		if (feedback.myo.distAlert != feedback.myo.ddistAlert) {
			if(feedback.myo.enabled){
				feedback.myo.thalmicMyo.Vibrate(VibrationType.Short);
			}
			feedback.myo.ddistAlert = feedback.myo.distAlert;
		}
	}

	//return an array of vectors that point from the supplied m_Transform to every player
	Vector3[] DirectionVectors()
	{
		List<Vector3> positions = new List<Vector3>();
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");

		foreach (GameObject p in players) {
			positions.Add( p.transform.position - m_Transform.position );
		}
		return positions.ToArray();
	}
}
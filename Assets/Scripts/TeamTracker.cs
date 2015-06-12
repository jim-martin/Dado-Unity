using UnityEngine;
using System;
using System.Collections.Generic;


[RequireComponent(typeof (Transform))]
public class TeamTracker : MonoBehaviour 
{
	[Serializable]
	public class FeedbackSettings
	{
		public float distanceThreshold = 5.0f;
		[HideInInspector] public Boolean distAlert = false;
		[HideInInspector] public Boolean ddistAlert = false;
	}

	public FeedbackSettings feedbackSettings = new FeedbackSettings();
	private Transform m_Transform;
	private Vector3[] team;
	private PhotonView m_PhotonView;
	private MyoFeedbackController m_MyoFeedbackController;

	void Start()
	{
		m_Transform = GetComponent<Transform> ();
		m_MyoFeedbackController = GetComponent<MyoFeedbackController> ();
		m_PhotonView = GetComponent<PhotonView> ();


		if (!m_PhotonView.isMine) {
			this.enabled = false;
		}
	}

	void Update()
	{
		feedbackSettings.distAlert = false;
		team = DirectionVectors();
		foreach (Vector3 v in team) {
			if(v.magnitude > feedbackSettings.distanceThreshold){
				feedbackSettings.distAlert = true;
				Debug.DrawLine( m_Transform.position, m_Transform.position + v, Color.red, 2f );
			}else{
				Debug.DrawLine( m_Transform.position, m_Transform.position + v, Color.yellow, 2f );
			}
		}

		if (feedbackSettings.distAlert != feedbackSettings.ddistAlert) {
			m_MyoFeedbackController.Vibrate();
			feedbackSettings.ddistAlert = feedbackSettings.distAlert;
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
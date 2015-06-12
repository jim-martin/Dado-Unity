using UnityEngine;
using System.Collections;

public class NetworkScriptManager : MonoBehaviour {

	public Camera cam;
	private PhotonView m_PhotonView;

	// Use this for initialization
	void Start () {
		m_PhotonView = GetComponent<PhotonView> ();
		if (!m_PhotonView.isMine) {

			MyoFeedbackController m_MyoFeedbackController = GetComponent<MyoFeedbackController>();
			m_MyoFeedbackController.enabled = false;

			TeamTracker m_TeamTracker = GetComponent<TeamTracker>();
			m_TeamTracker.enabled = false;

			NetworkFPSController m_NetworkFPSController = GetComponent<NetworkFPSController>();
			m_NetworkFPSController.enabled = false;

			cam.GetComponent<AudioListener>().enabled = false;
			cam.enabled = false;
		}
		this.enabled = false;
	}
}

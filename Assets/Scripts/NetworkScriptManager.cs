using UnityEngine;
using System.Collections;
using Data;

public class NetworkScriptManager : MonoBehaviour {

	public Camera cam;
	private PhotonView m_PhotonView;

	// Use this for initialization
	void Start () {
		m_PhotonView = GetComponent<PhotonView> ();
		if (!m_PhotonView.isMine) {

			NetworkFPSController m_NetworkFPSController = GetComponent<NetworkFPSController>();
			m_NetworkFPSController.enabled = false;

			DataComponent d = GetComponent<DataComponent>();
			d.enabled = false;

			DataLog log = GetComponent<DataLog>();
			log.enabled = false;

			cam.GetComponent<AudioListener>().enabled = false;
			cam.enabled = false;
		}
		this.enabled = false;
	}
}

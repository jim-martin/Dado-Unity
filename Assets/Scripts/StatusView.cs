using UnityEngine;
using System.Collections;

[RequireComponent( typeof( PhotonView ) )]
[AddComponentMenu("Photon Networking/Photon Status View")]
public class StatusView : MonoBehaviour {

	public bool needHelp = false;
	public bool canContinue = true;

	// Use this for initialization
	void Awake () {
		Debug.Log ("awake");
	}

	// Update is called once per frame
	void OnPhotonSerializeView( PhotonStream stream, PhotonMessageInfo info )
	{
		Debug.Log ("serializing view");
	}

	void Update(){
//		if(Input.GetKeyDown( "Alpha1" )){
//			NeedHelpToggle();
//}
//		if(Input.GetKeyDown( "Alpha2" )){
//			CanContinueToggle();
//		}

	}

	void NeedHelpToggle(){
		needHelp = !needHelp;
	}

	void CanContinueToggle(){
		canContinue = !canContinue;
	}
}

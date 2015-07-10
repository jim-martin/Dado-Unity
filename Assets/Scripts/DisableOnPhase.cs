using UnityEngine;
using System.Collections;

public class DisableOnPhase : MonoBehaviour {

	public string phaseName;

	GameController gc;

	// Use this for initialization
	void Start () {

		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		gc.getPhaseByName(phaseName).StartPhase += Disable;

	}

	void ChangePhase( string newPhase ){

		gc.getPhaseByName(phaseName).StartPhase -= Disable;
		gc.getPhaseByName(newPhase).StartPhase += Disable;
		phaseName = newPhase;

	}

	void Disable (){

		Debug.Log("DISABLEING PATH : " + gameObject.name);
		gameObject.SetActive(false);

	}
}

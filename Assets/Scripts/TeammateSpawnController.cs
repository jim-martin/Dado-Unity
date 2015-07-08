using UnityEngine;
using System.Collections;

public class TeammateSpawnController : MonoBehaviour {

	GameController gc;
	GameObject[] spawns;

	// Use this for initialization
	void Awake () {

		gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		spawns = GameObject.FindGameObjectsWithTag ("team_spawn");

	}

	void Start(){

		gc.getPhaseByName ("targetSearch").StartPhase += PlaceTarget;

	}
	
	void PlaceTarget () {
		Debug.Log ("PLACE TEAM TARGET");
	}
}

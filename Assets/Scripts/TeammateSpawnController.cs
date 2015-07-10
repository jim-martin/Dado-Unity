using UnityEngine;
using System.Collections;
using System;

public class TeammateSpawnController : MonoBehaviour {

	GameController gc;
	GameObject p;
	GameObject[] spawns;
	GameObject[] trails;

	// Use this for initialization
	void Awake () {

		gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		spawns = GameObject.FindGameObjectsWithTag ("team_spawn");
		trails = GameObject.FindGameObjectsWithTag ("TeamTrail");

	}

	void Start(){

		gc.getPhaseByName ("targetSearch").StartPhase += PlaceTarget;

	}

	//hotfix for fucked up transform behavior
	
	void PlaceTarget () {

		//get the player's position
		try{
			p = GameObject.FindGameObjectWithTag ("Player");
		}catch( UnityException e){
			Debug.Log(e);
			return;
		}

		//place target on the second(?) nearest spawn to the player

		//get distances for all the points
		float[] dist = new float[spawns.Length];
		for (int i = 0; i < spawns.Length; i++) {
 			dist[i] = Vector3.Distance(p.transform.position, spawns[i].transform.position);
		}

		//sort the points
		float[] sorted = (float[])(dist.Clone());
		Array.Sort (sorted); 

		//get the original index of the point we want to spawn the player on
		int index = 0;
		for (int j = 0; j < dist.Length; j++) {
			if (dist [j].Equals (sorted [1])) {
				index = j;
			}
		}

		//apply the transform
		transform.position = spawns [index].transform.position;

		//clear the trails that aren't associated with the chosen spawn location
		string n = spawns[index].gameObject.name;
		for(int k = 0; k < trails.Length; k++){
			if(!trails[k].name.Equals(n)){
				trails[k].gameObject.SetActive(false);
			}
		}
	}
}

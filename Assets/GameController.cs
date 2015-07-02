using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public string p1_targets = "p1 target";
	public string p2_targets = "p2 target";
	public string p3_targets = "p3 target";
	public string p4_targets = "p4 target";

	int currentPhase = 0;
	int phaseTime = 10;

	Phase[] phases;
	Phase clearFloor;
	Phase incident;
	Phase targetSearch;
	Phase exit;
	Phase idle;

	// Use this for initialization
	void Start () {
		//define phase parameters for each phase
		clearFloor = new Phase (p1_targets, phaseTime);
		incident = new Phase (p2_targets, phaseTime);
		targetSearch = new Phase (p3_targets, phaseTime);
		exit = new Phase (p4_targets, phaseTime);
		idle = new Phase ();

		phases = new Phase[]{idle, clearFloor, incident, targetSearch, exit, idle};
		//start the first phase

	}

	void Update (){
		if (phases [currentPhase].CheckComplete ()) {
			if(phases[currentPhase].success){
				StepPhase();
			}else{
				EndGame();
			}
		}
	}

	public void StepPhase(){
		if (currentPhase < phases.Length - 1) {
			currentPhase++;
			phases [currentPhase].StartPhase ();
			Debug.Log("NEW PHASE : " + currentPhase);
		} else {
			EndGame();
		}
	}

	public void EndGame(){
		//show logs?, move to new scene maybe
		Debug.Log ("GAME OVER MUTHAFUCKA");
		currentPhase = 0;
	}

	
	public int getPhase(){
		return currentPhase;
	}

	public int[] getTargetsHit(){
		return phases [currentPhase].targetsHit;
	}


	class Phase{
		public float timeLimit;
			   float timeStart;

		public string targetTag;
		public GameObject[] targets;
		public int[] targetsHit;
		public int targetsLeft;

		public bool success = true;


		//Constructor for a target/timelimit phase
		public Phase( string tag, int t ){
			timeLimit = t;
			targetTag = tag;
			FindTargets();
		}

		//constructor for a time unlimitted phase
		public Phase( string tag ){
			timeLimit = -1;
			targetTag = tag;
			FindTargets();
		}


		//constructor for the idle phase ( no parameters means no constraints )
		public Phase( ){
			targetsLeft = 1;
			timeLimit = -1;
		}

		public void StartPhase(){
			timeStart = Time.time;
		}

		public bool CheckComplete(){

			if (targets != null) {

				for (int i = 0; i < targets.Length; i++) {

					TriggerTarget t = targets [i].GetComponent<TriggerTarget> ();

					if (t == null) {
						Debug.Log ("Target " + i + " doesn't have a TriggerTarget");
					} else {

						if (t.isTriggered == true && targetsHit [i] == 0) {

							Debug.Log ("target triggered");
							targetsHit [i] = 1;
							targetsLeft--;
						}
					}
				}
			}

			//return true if the target was reached or if the time is up 
			//(include other failure conditions here)
			if (targetsLeft < 1 || 						//target(s) are found
			    (Time.time - timeStart > timeLimit && timeLimit > 0)) {	//timelimit for phase is up, assuming time is limited
				return true;
			} else {
				return false;
			}
		}

		public void FindTargets(){
			targets = GameObject.FindGameObjectsWithTag (targetTag);
			targetsHit = new int[targets.Length];

			for (int i = 0; i < targetsHit.Length; i++) {
				targetsHit[i] = 0;
			}

			targetsLeft = targets.Length;
		}
	}
}

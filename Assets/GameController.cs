using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public string p1_targets = "p1 target";
	public string p2_targets = "p2 target";
	public string p3_targets = "p3 target";
	public string p4_targets = "p4 target";

	
	int currentPhase = 0;
	int phaseTime = 10;

	//condition
//	static int _CONTROL = 0;
//	static int _VISUAL = 1;
//	static int _AUDIO = 2;

	int condition = 1;


	//profile arrays for all conditions defined for each phase (profile names)
	//
	string [] clearFloorProfiles = new string[]{"control", "paths", "audio_history"};
	string [] targetSearchProfiles = new string[]{"control", "radar", "pings"};
	string [] exitProfiles = new string[]{"control", "control", "control"};
	string [] idleProfiles = new string[]{"control", "control", "control"};



	Phase[] phases;
	Phase clearFloor;
	Phase targetSearch;
	Phase exit;
	Phase idle;

	// Use this for initialization
	void Start () {
		//define phase parameters for each phase
		clearFloor = new Phase (p1_targets, clearFloorProfiles, phaseTime);
		targetSearch = new Phase (p3_targets, targetSearchProfiles, phaseTime);
		exit = new Phase (p4_targets, exitProfiles, phaseTime);
		idle = new Phase (idleProfiles);

		phases = new Phase[]{idle, clearFloor, targetSearch, exit, idle};
		//start the first phase
		StepPhase ();

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
			phases [currentPhase].StartPhase (condition);
			Debug.Log("NEW PHASE : " + currentPhase);
			Debug.Log ("\tPROFILE : " + phases[currentPhase].profiles[condition]);
		} else {
			EndGame();
		}
	}

	public void EndGame(){
		//show logs?, move to new scene maybe
		Debug.Log ("GAME OVER MUTHAFUCKA");
		currentPhase = 0;
		phases [currentPhase].StartPhase (condition);
	}
	
	
	public int getPhase(){
		return currentPhase;
	}

	public int[] getTargetsHit(){
		return phases [currentPhase].targetsHit;
	}

	public void setCondition( int c ){
		condition = c;
		//update profiles
	}

	public int getCondition(){
		return condition;
	}


	class Phase{
		public float timeLimit;
			   float timeStart;

		public string targetTag;
		public GameObject[] targets;
		public int[] targetsHit;
		public int targetsLeft;

		public bool success = true;

		public string[] profiles;
		public int condition;


		//Constructor for a target/timelimit phase
		public Phase( string tag, string[] p, int t ){
			timeLimit = t;
			targetTag = tag;
			FindTargets();

			profiles = p;
		}

		//constructor for a time unlimitted phase
		public Phase( string tag, string[] p ){
			timeLimit = -1;
			targetTag = tag;
			FindTargets();

			profiles = p;
		}


		//constructor for the idle phase ( no parameters means no constraints )
		public Phase( string[] p ){
			targetsLeft = 1;
			timeLimit = -1;

			profiles = p;
		}

		public void StartPhase( int condition ){
			timeStart = Time.time;

			//update feedback profiles
			ProfileComponent player = GameObject.FindGameObjectWithTag ("Player").GetComponent<ProfileComponent> ();
//			player.loadProfile (profiles [condition]);
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

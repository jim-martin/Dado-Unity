﻿using UnityEngine;
using System.Collections;
using Data;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameController : MonoBehaviour {

	public string p1_targets = "p1 target";
	public string p2_targets = "p2 target";
	public string p3_targets = "p3 target";
	public string p4_targets = "p4 target";

	//define delegates
	public delegate void delegate_StepPhase();
	public delegate_StepPhase StepPhase;

	public delegate void delegate_EndGame();
	public delegate_EndGame EndGame;

	public delegate void delegate_LateStepPhase();
	public delegate_LateStepPhase LateStepPhase;

	
	int currentPhase = 0;
	int phaseTime = 60;

	//condition
//	static int _CONTROL = 0;
//	static int _VISUAL = 1;
//	static int _AUDIO = 2;

	int condition;


	Phase[] phases;
	Phase clearFloor;
	Phase targetSearch;
	Phase exit;
	Phase idle;

	//HACK AS FUCK -- shouldn't be reaching into player data in the gamecontroller, but this is easiest for now.
	HistoricalData h;


	void Awake(){

		//pause game time until the game starts
		Time.timeScale = 0;
		PlayerPrefs.SetInt("CurrentPlayerScore", 0);

		Screen.lockCursor = true;

		//profile arrays for all conditions defined for each phase (profile names)
		//
		/*	control		--nothing
	 *  paths 		--trails
	 * 	radar		--radar disk
	 * 	pings		--targetted search style pings
	 *  audio_paths	--trails represented with audio
	 */
		string [] clearFloorProfiles = new string[]{"control", "paths", "audio_paths", PlayerPrefs.GetString("customProfile")};
		string [] targetSearchProfiles = new string[]{"control", "radar,paths", "pings", PlayerPrefs.GetString("customProfile")};
		string [] exitProfiles = new string[]{"control", "paths", "audio_paths", PlayerPrefs.GetString("customProfile")};

		//define phase parameters for each phase
		clearFloor = new Phase (p1_targets, clearFloorProfiles, 100);
		clearFloor.name = "clearFloor";

		targetSearch = new Phase (p3_targets, targetSearchProfiles, 100);
		targetSearch.name = "targetSearch";

		exit = new Phase (p4_targets, exitProfiles, 100);
		exit.name = "exit";

		idle = new Phase ();
		idle.name = "idle";

		//establish phase order
		phases = new Phase[]{idle, clearFloor, targetSearch, exit};

		//Define Delegates
		StepPhase += _StepPhase;
		EndGame += _EndGame;

		//HACK AS FUCK -- shouldn't be reaching into player data in the gamecontroller, but this is easiest for now.
		h = GameObject.FindGameObjectWithTag("Player").GetComponent<HistoricalData>();


	}

	void Update (){
		if (phases [currentPhase].CheckComplete ()) {
			StepPhase();
		}

		if(h.air < 1.0f){
			if(!(phases [currentPhase].name.Equals("exit") || phases [currentPhase].name.Equals("idle"))){
				currentPhase = 2;
				StepPhase();
			}
		}
	}

	public void StartGame(){

		//container for the stepphase function because the button GUI 
		//doesn't seem to reflect through delegates like it should.
		StepPhase();

		//start the timescale normally on game start
		Time.timeScale = 1;
	}

	public void _StepPhase(){

		//end current phase 
		phases [currentPhase].EndPhase ();

		//start next phase if there is one, otherwise, end the game (return to idle phase);
		if (currentPhase < phases.Length - 1) {
			currentPhase++;
			phases [currentPhase].StartPhase ();
			Debug.Log("NEW PHASE : " + phases[currentPhase].name);
			Debug.Log ("\tPROFILE : " + phases[currentPhase].profiles[condition]);
		} else {
			EndGame();
		}

		LateStepPhase();
	}

	public void _EndGame(){
		//show logs?, move to new scene maybe
		currentPhase = 0;
		phases [currentPhase].StartPhase ();

		int i = PlayerPrefs.GetInt( "testStep" );
		int j = PlayerPrefs.GetInt( "totalTestSteps" );
		i++;

		PlayerPrefs.SetInt( "testStep" , i);

		Debug.Log(i%j);
		if((i % j) == 0 ){
			//stop game time
			Time.timeScale = 0;

			//Invoke("QuitApp", 3);
			Debug.Log ("GAME ENDING IN 3...");
		}else{
			//Invoke("LoadNextScene", 3);
			Debug.Log("NEXT TEST LOADING IN 3...");
		}

	}

	void LoadNextScene(){
		Application.LoadLevel(0);
	}

	public void QuitApp(){

		Debug.Log("Exiting application");
		Application.Quit();

		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}

	
	public int getPhase(){
		return currentPhase;
	}

	public Phase getPhaseObject(){

		return phases [currentPhase];
	}

	public Phase getPhaseByName( string name ){

		int p = -1;

		for (int i = 0; i < phases.Length; i++) {
			if(phases[i].name == name){
				p = i;
			}
		}

		if (p > -1) {
			return phases [p];
		} else {
			return null;
		}
	}

	public int[] getTargetsHit(){
		return phases [currentPhase].targetsHit;
	}

	public void setCondition( int c ){
		//set high level condition
		condition = c;
		//update phases' conditions
		foreach( Phase p in phases ){
			p.condition = c;
		}
	}

	public int getCondition(){
		return condition;
	}
	
}

public class Phase{
	public string name;

	public float timeLimit;
	float timeStart;
	
	public string targetTag;
	public GameObject[] targets;
	public int[] targetsHit;
	public int targetsLeft;

	public bool success = false;
	public int successValue = 500;
	
	public string[] profiles;
	public int condition;


	//define Delegates
	public delegate void delegate_StartPhase();
	public delegate_StartPhase StartPhase;

	public delegate void delegate_EndPhase();
	public delegate_StartPhase EndPhase;
	
	
	//Constructor for a target/timelimit phase
	public Phase( string tag, string[] p, int t ){
		timeLimit = t;
		targetTag = tag;

		if(!FindTargets()){
			//Debug.Log ("Couldn't find any targets with tag : " + targetTag);
		}

		//define profiles
		profiles = p;

		//subscribe delegates
		StartPhase += _StartPhase;
		EndPhase += _EndPhase;
	}
	
	//constructor for a time unlimitted phase
	public Phase( string tag, string[] p ){
		timeLimit = -1;
		targetTag = tag;
		if(!FindTargets()){
			//Debug.Log ("Couldn't find any targets with tag : " + targetTag);
		}

		//define profiles
		profiles = p;

		//subscribe delegates
		StartPhase += _StartPhase;
		EndPhase += _EndPhase;
	}
	
	
	//constructor for the idle phase ( no parameters means no constraints )
	public Phase(){
		targetsLeft = 1;
		timeLimit = -1;

		//define profiles
		profiles = new string[]{"control", "control", "control", "control"};

		//subscribe Delegates
		StartPhase += _StartPhase;
		EndPhase += _EndPhase;
	}
	
	public void _StartPhase(){
		timeStart = Time.time;
		
		//update feedback profiles
	//	ProfileComponent player = GameObject.FindGameObjectWithTag ("Player").GetComponent<ProfileComponent> ();


		//ensure that the targets for this phase are enabled
		if (targets != null) {
			for(int i = 0; i < targets.Length; i++){
				//targets[i].GetComponent<MeshRenderer>().enabled = true;
			}
		}
	}

	public void _EndPhase(){

		//disable the targets for this phase
		if (targets != null) {
			for(int i = 0; i < targets.Length; i++){
				targets[i].GetComponent<MeshRenderer>().enabled = false;
			}
		}
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
		if (targetsLeft < 1 ){
			//add to the score for success
			success = true;
			int s = PlayerPrefs.GetInt("CurrentPlayerScore", 0);
			s += successValue;

			Debug.Log ("** SCORE ** : " + s);
			PlayerPrefs.SetInt("CurrentPlayerScore", s);

			return true;
		}else if(Time.time - timeStart > timeLimit && timeLimit > 0) {	//timelimit for phase is up, assuming time is limited
			//subtract from score?
			success = false;
			return true;
		} else {
			return false;
		}
	}
	
	public bool FindTargets(){
		targets = GameObject.FindGameObjectsWithTag (targetTag);
		targetsHit = new int[targets.Length];
		
		for (int i = 0; i < targetsHit.Length; i++) {
			targetsHit[i] = 0;
		}
		
		targetsLeft = targets.Length;
		if(targets.Length < 1){
			return false;
		}else{
			return true;
		}
	}
}

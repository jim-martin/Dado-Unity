using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;


namespace Data
{
	[RequireComponent (typeof (HistoricalData))]
	public class CalloutLogger : MonoBehaviour {

		public float airCalloutFreq = 5.0f; 

		/* 1 - timestamp
		 * 2 - callout_type
		 * 3 - response_time
		 * 4 - success
		 */
		string csv_header = "timestamp,callout_type,response_time,success";
		List<string> airLogs;

		HistoricalData h;
		GameController gc;

		float stepStartTime_air;
		float stepStartAir;
		bool respondedAir = true;

		float[] callTimes = new float[6]{26.0f, 30.0f, 42.0f, 55.0f, 65.0f, 100.0f};
		int currentStep_ladder = 0;
		float stepStartTime_ladder;
		bool respondedLadder = true;

		// Use this for initialization
		void Start () {

			gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
			h = GetComponent<HistoricalData> ();
			airLogs = new List<string> ();

			stepStartAir = h.air;
			stepStartTime_air = Time.time;
			stepStartTime_ladder = Time.time;

			//subscribe the export function to endgame
			gc.EndGame += Export;
		
		}
		
		// Update is called once per frame
		void Update () {

			//check for air status, call step if neccessary
			if (h.air < Mathf.Floor(stepStartAir - airCalloutFreq)) { //floor rounding is so that the key can be pressed right when the # changes in the HUD
				StepCalloutAir();
			}

			//compare gametime to the logged ladder6 times to see if the state needs to be stepped.
			if ((Time.time % 151.0f) > callTimes[(currentStep_ladder % callTimes.Length)]){
				StepCalloutLadder();
			}

			//check for response input
			if (Input.GetKeyDown ("space")) {
				if(!respondedAir){
					LogResponse( true , "air" );
				}

				if(!respondedLadder){
					LogResponse( true, "ladder");
				}
			}
		
		}

		void StepCalloutAir(){
			//if !responded, log the last step as a failure
			if (!respondedAir) {
				LogResponse(false, "air" );
			}

			//start listening for a new response
			respondedAir = false;

			//store start time of step
			stepStartTime_air = Time.time;

			//store start air of step
			stepStartAir -= airCalloutFreq;

//			Debug.Log ("CALLOUT STEP START : ");
//			Debug.Log ("\tTime : " + stepStartTime);
//			Debug.Log ("\tAir : " + stepStartAir);
		}

		void StepCalloutLadder(){

			//Debug.Log("LADDERCALLOUT STEP : " + currentStep_ladder);

			currentStep_ladder++;

			if (!respondedLadder) {
				//Debug.Log("\tYOU FAILED");
				LogResponse(false, "ladder" );
			}

			respondedLadder = false;


		}

		//always called before callout is stepped
		void LogResponse( bool succes, string type ){

			//-1 in output means something wasn't assigned properly
			float responseDelay = -1.0f;

			//stop listening for new responses
			if(type.Equals("air")){
				respondedAir = true;
				//ResponseDelay
				responseDelay = Time.time - stepStartTime_air;
			}

			if(type.Equals("ladder")){
				//Debug.Log("LADDER CALLOUT LOGGED");
				respondedLadder = true;
				//ResponseDelay
				responseDelay = Time.time - stepStartTime_ladder;
			}

			//FIELDS TO LOG:
			//TimeStamp
			float tStamp = Time.time;

			//CalloutType

			//Success

			//store response length?
			//there would have to be a separate "response" object/string stored somewhere
			//get this done after the initial LogResponse() call.

			//create csv line, store it?
			string csv_line = "";
			csv_line += tStamp.ToString() + ",";
			csv_line += type.ToString() + ",";
			csv_line += responseDelay.ToString() + ",";
			csv_line += succes.ToString ();

//			Debug.Log(csv_line);
			airLogs.Add (csv_line);
		}

		void Export(){

			Debug.Log ("Exporting Callout Logs");

			int playerID = (int)Mathf.Floor((PlayerPrefs.GetInt("testStep")-1) / PlayerPrefs.GetInt("totalTestSteps"));
			int logID = (PlayerPrefs.GetInt("testStep") % PlayerPrefs.GetInt("totalTestSteps"));
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./Assets/logs/participant" + playerID + "callout_log" + logID + "_"+System.DateTime.Now.ToString("yyyyMMddHHmmssffff")+".csv", true)) {
				//write header line
				file.WriteLine (csv_header);

				foreach( string line in airLogs ){
					file.WriteLine(line);
				}
			}
		}
	}

}
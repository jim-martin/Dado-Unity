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

		float stepStartTime;
		float stepStartAir;
		bool responded = true;

		// Use this for initialization
		void Start () {

			gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
			h = GetComponent<HistoricalData> ();
			airLogs = new List<string> ();

			stepStartAir = h.air;
			stepStartTime = Time.time;

			//subscribe the export function to endgame
			gc.EndGame += Export;
		
		}
		
		// Update is called once per frame
		void Update () {

			//check for air status, call step if neccessary
			if (h.air < Mathf.Floor(stepStartAir - airCalloutFreq)) { //floor rounding is so that the key can be pressed right when the # changes in the HUD
				StepCallout();
			}


			//check for response input
			if (Input.GetKeyDown ("space")) {
				if(!responded){
					LogResponse( true , "air" );
				}
			}
		
		}

		void StepCallout(){
			//if !responded, log the last step as a failure
			if (!responded) {
				LogResponse(false, "air" );
			}

			//start listening for a new response
			responded = false;

			//store start time of step
			stepStartTime = Time.time;

			//store start air of step
			stepStartAir -= airCalloutFreq;

//			Debug.Log ("CALLOUT STEP START : ");
//			Debug.Log ("\tTime : " + stepStartTime);
//			Debug.Log ("\tAir : " + stepStartAir);
		}

		//always called before callout is stepped
		void LogResponse( bool succes, string type ){

			//stop listening for new responses
			responded = true;

			//FIELDS TO LOG:
			//TimeStamp
			float tStamp = Time.time;

			//CalloutType

			//ResponseDelay
			float responseDelay = Time.time - stepStartTime;

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

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./Assets/logs/callout_log_"+System.DateTime.Now.ToString("yyyyMMddHHmmssffff")+".csv", true)) {
				//write header line
				file.WriteLine (csv_header);

				foreach( string line in airLogs ){
					file.WriteLine(line);
				}
			}
		}
	}

}
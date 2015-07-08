using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

namespace Data
{
	public class HistoricalData : MonoBehaviour
	{
		
		public float logIncrement = 1.0f;
		private List<Marker> trail;
		private List<Marker> imported_trail;

		//external components
		Transform view_Transform;
		GameController gc;
		
		//in historicaldata
		public float total_distance;
		public int total_idle;
		public float phase_distance;
		public int phase_idle;
		public float air = 100f;
		public float mobility;
		public TextAsset import_csv;
		public bool NPC; //don't log if NPC == true

		public float air_constant_decrease;
		public float air_movement_decrease;
		int exported = 0;
		
		//game controller:
		//phase
		//targets
		//target distance
		//query targets
		
		
		
		// Use this for initialization
		void Start ()
		{
			if (import_csv != null) {
				imported_trail = import_csv_into_markers (import_csv);

				test_imported_markers ();
			}

			if (air_constant_decrease == null || air_constant_decrease == 0) {
				air_constant_decrease = 0.05f;
			}
			if (air_movement_decrease == null || air_movement_decrease == 0) {
				air_movement_decrease = 0.3f;
			}

			trail = new List<Marker> ();
			
			//get the viewTransform (to log where the player was looking)
			try {
				DataComponent d = GetComponent<DataComponent> ();
				if (d != null) {
					view_Transform = d.view_Transform;
				}
			} catch (UnityException e) {
				Debug.Log (e);
			}

			gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
			
			total_distance = 0f;
			total_idle = 0;
			phase_distance = 0f;
			phase_idle = 0;
			air = 100f;
			mobility = 1f;
			
			//log da shit
			StartLogging ();

			//subscribe export function to gc's endgame
			gc.EndGame += export_all_markers_to_csv;
		}
		
		void Update ()
		{
			if (view_Transform == null) {
				view_Transform = GetComponent<Transform> ();
			}
			
			DrawDebugTrail ();
		}
		
		void StartLogging ()
		{
			InvokeRepeating ("LogMarker", 0.1f, logIncrement);
		}
		
		void StopLogging ()
		{
			CancelInvoke ("LogMarker");
		}
		
		void UpdateAir (float distance_change)
		{
			air -= air_constant_decrease;
//			Debug.Log ("distance change: " + distance_change);
			air -= distance_change * air_movement_decrease;
//			Debug.Log ("new air: " + air);
			//todo: needs to be scaled	
		}

		public float getAir ()
		{
			return air;
		}

		public List<Marker> get_imported_trail(){
			return imported_trail;
		}

		void LogMarker ()
		{
			//stop logging if the data has already been exported
			if (exported == 1) 
				return;

				//create a new marker
				Marker m = new Marker ();
				m.position = view_Transform.position;
				m.rotation = view_Transform.rotation;
				m.timeCreated = Time.time;
			
				//set total_distance
				m.distance_change = 0;
//				Debug.Log ("trail count: " + trail.Count);
				if (trail.Count > 0) {
					//difference from past marker
					m.distance_change = Vector3.Distance (trail [trail.Count - 1].position, m.position);
//					Debug.Log ("distance change: " + m.distance_change);
					total_distance += m.distance_change;
				}
				m.total_distance = total_distance;
				//total_idle
			
			
				UpdateAir (m.distance_change);
				m.air_level = air;
			
				//get phase from gamecontroller
				m.phase = gc.getPhase ();
//				Debug.Log ("phase: " + gc.getPhase ());
				//check phase
				//compare phase to previous marker
//				if phase1 != phase2

				if (trail.Count == 0) {
					m.key_frame = 1;
				} else if (m.phase > trail [trail.Count - 1].phase) {
					//mark keyframe
					m.key_frame = 1;
					trail [trail.Count - 1].key_frame = 2;
					//mark previous as keyframe
				
					//reset phase_distance
					phase_distance = m.distance_change;
				
					//reset phase_idle
					phase_idle = 0;
				} else {
					m.key_frame = 0;
					phase_distance += m.distance_change;
				}
			
				if (m.distance_change == 0) {
					total_idle ++;
					phase_idle ++;
				}
			
				m.phase_traveled = phase_distance;
			
			
				m.mobility = mobility;
			
			
				//targets
				//target distance
			
				//need a functions for:
				//closest target distance
				//air

				//targets
				//gc.getTargets() -- returns array
				int[] targets_hit = gc.getTargetsHit ();
//				Debug.Log (targets_hit);
				m.targets = targets_hit;

			
				//key frame
				m.export_marker_to_csv_line ();
			
				//add it to the list
				trail.Add (m);
		}
		
		void DrawDebugTrail ()
		{
			if (trail.Count > 2) {
				for (int i = 0; i < trail.Count - 2; i++) {
					Color c = Color.red;
					if (Time.time - trail [i].timeCreated < 4)
						c = Color.yellow;
					if (Time.time - trail [i].timeCreated < 2)
						c = Color.green;
					Debug.DrawLine (trail [i].position, trail [i + 1].position, c);
					Debug.DrawRay (trail [i].position, trail [i].rotation * Vector3.forward);
				}
			}
		}
		
		public List<Marker> get_trail ()
		{
			return trail;
		}
		
		public void export_all_markers_to_csv ()
		{
			Debug.Log ("export to CSV");
			//export the current scenario / presentation profile

			//choose file

			//make the last frame key_frame=2
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./Assets/logs/test_log_"+System.DateTime.Now.ToString("yyyyMMddHHmmssffff")+".csv", true)) {
				//write header line
				file.WriteLine (trail [0].csv_header_line ());
				
				//for each marker
				//call marker.export_marker_to_csv_line();
				foreach (Marker mark in trail) {
					file.WriteLine (mark.export_marker_to_csv_line ());
				}


			}

			exported = 1;
		}

		public void test_imported_markers ()
		{
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./Assets/logs/import_test.csv", true)) {
				//write header line
				file.WriteLine (imported_trail [0].csv_header_line ());
					
				//for each marker
				//call marker.export_marker_to_csv_line();
				foreach (Marker mark in imported_trail) {
					file.WriteLine (mark.export_marker_to_csv_line ());
				}
			}
		}

		public List<Marker> import_csv_into_markers (TextAsset file)
		{


			string[] lines = file.text.Split ("\n" [0]);
			List<Marker> imported_markers = new List<Marker> ();
			for (int i = 1; i < lines.Length - 1; i++) { //first line is header, last line is a blank line
				string line = lines [i];
				Marker new_marker = new Marker ();
				new_marker.import_from_csv_line (line);
				imported_markers.Add (new_marker);
			}

			//Debug.Log ("imported markers");
			//Debug.Log (imported_markers);
			return imported_markers;
		}
	}
	
	public class Marker
	{
		//current position
		public Vector3 position;
		
		//current direction
		public Quaternion rotation;
		
		//timestamp
		public float timeCreated;
		
		//phase
		public int phase;
		
		//targets hit
		public int[] targets;
		public float distance_change;
		
		//total distance traveled
		public float total_distance;
		
		//total time idle
		public int total_idle;
		
		//phase distance traveled
		public float phase_traveled;
		
		//phase time idle
		public int phase_idle;
		
		//distance from target(s)
		public float target_distance;
		
		//current air level
		public float air_level;
		public float mobility;
		//status?
		
		//if first or last
		public int key_frame;
		
		public string export_marker_to_csv_line ()
		{
			string csv_line = "";
			//add timestamp - 1
			csv_line += timeCreated.ToString () + ",";
			
			//add phase - 2
			csv_line += phase.ToString () + ",";
			
			//distance change  - 3
			csv_line += distance_change.ToString () + ",";
			
			//total distance traveled - 4
			csv_line += total_distance.ToString () + ",";
			
			//current position 5,6,7
			//			public Vector3 position;
//			Debug.Log (position);
			csv_line += position.x.ToString () + "," + position.y.ToString () + "," + position.z.ToString () + ",";
			//xpos, ypos, zpos
			
			//current direction 8,9,10,11
			//			public Quaternion rotation;
//			Debug.Log (rotation.ToString ().Substring (1, rotation.ToString ().Length - 2) + ",");
			//q1, q2, q3, q4
			csv_line += rotation.ToString ().Substring (1, rotation.ToString ().Length - 2) + ",";

			//total time idle - 12
			csv_line += total_idle.ToString () + ",";
			
			//phase distance traveled
			csv_line += phase_traveled.ToString () + ",";
			
			//phase time idle
			csv_line += phase_idle.ToString () + ",";
			
			//distance from target(s)
			csv_line += target_distance.ToString () + ",";
			
			//current air level
			csv_line += air_level.ToString () + ",";
			
			csv_line += mobility.ToString () + ",";
			
			//if first or last
			csv_line += key_frame.ToString ();

			//targets hit
			//encode as "100010101" etc, based on the target array length
			//			public int[] targets;
			if (targets != null) {
				csv_line += ",";
				foreach (int targ in targets) {
					csv_line += targ.ToString ();
				}
			}
			
			//Debug.Log (csv_line);
			
			return csv_line;
		}

		public string csv_header_line ()
		{
			/* 1 - timestamp
			 * 2 - phase
			 * 3 - distance change
			 * 4 - total distance traveled
			 * 5 - position X
			 * 6 - position Y
			 * 7 - position Z
			 * 8 - quaternion X
			 * 9 - quaternion Y
			 * 10 - quaternion Z
			 * 11 - quaternion W
			 * 12 - Total steps idle
			 * 13 - Phase distance traveled
			 * 14 - Phase steps idle
			 * 15 - Distance from target
			 * 16 - Air level
			 * 17 - Mobility
			 * 18 - Key frame
			 * 19-? - Targets
			 * 
			 */

			return "Timestamp,Current Phase,Distance Change,Total Distance Traveled,Position X,Position Y,Position Z,Quaternion X,Quaternion Y,Quaternion Z,Quaternion W,Total Steps Idle,Phase Distance Traveled,Phase Steps Idle,Distance from Target,Air Level, Mobility,Key Frame,Targets";
		}

		public void import_from_csv_line (string line)
		{

			//Debug.Log (line);

			string[] fields = line.Split ("," [0]); //split on ','
			if (fields.Length > 0) {

				// 0 - timestamp
//				Debug.Log("BeforeFormatException");
				timeCreated = float.Parse (fields [0]);

				// 1 - phase
				phase = int.Parse (fields [1]);

				// 2 - distance change
				distance_change = float.Parse (fields [2]);

				// 3 - total distance traveled
				total_distance = float.Parse (fields [3]);

				// 4 - position X
				// 5 - position Y
				// 6 - position Z
				position = new Vector3 (float.Parse (fields [4]), float.Parse (fields [5]), float.Parse (fields [6]));

				// 7 - quaternion X
				// 8 - quaternion Y
				// 9 - quaternion Z
				// 10 - quaternion W
				rotation = new Quaternion (float.Parse (fields [7]), float.Parse (fields [8]), float.Parse (fields [9]), float.Parse (fields [10]));

				// 11 - Total steps idle
				total_idle = int.Parse (fields [11]);

				// 12 - Phase distance traveled
				phase_traveled = float.Parse (fields [12]);

				// 13 - Phase steps idle
				phase_idle = int.Parse (fields [13]);

				// 14 - Distance from target
				target_distance = float.Parse (fields [14]);

				// 15 - Air level
				air_level = float.Parse (fields [15]);

				// 16 - Mobility
				mobility = float.Parse (fields [16]);

				// 17 - Key frame
				key_frame = int.Parse (fields [17]);

				// 18-? - Targets
				if (fields.Length > 18) { //looks like markers are being written in the menu before a condition is selected
					targets = new int[fields [18].Length];
					for (int i = 0; i < fields[18].Length; i++) {
						int val = 0;
						if(int.TryParse ((fields [18].Substring (i, 1)), out val))
							targets [i] = val;
					}
				}
			}





		}
	}
	
	
}

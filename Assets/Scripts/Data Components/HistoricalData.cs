using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

namespace Data
{
	public class HistoricalData : MonoBehaviour {

		public float logIncrement = 1.0f;
		private List<Marker> trail;
		Transform view_Transform;

		//in historicaldata
		public float total_distance;
		public int total_idle;
		public float phase_distance;
		public int phase_idle;
		public float air;
		public float mobility;

		//game controller:
		//phase
		//targets
		//target distance
			//query targets



		// Use this for initialization
		void Start () {
			trail = new List<Marker> ();

			//get the viewTransform (to log where the player was looking)
			try{
				DataComponent d = GetComponent<DataComponent> ();
				if(d != null){
				view_Transform = d.view_Transform;
				}
			}
			catch(UnityException e){
				Debug.Log (e);
			}

			total_distance = 0f;
			total_idle = 0;
			phase_distance = 0f;
			phase_idle = 0;
			air = 100f;
			mobility = 1f;

			//log da shit
			StartLogging ();
		}

		void Update(){
			if (view_Transform == null) {
				view_Transform =  GetComponent<Transform> ();
			}

			DrawDebugTrail ();
		}

		void StartLogging(){
			InvokeRepeating ("LogMarker", 0.1f, logIncrement);
		}

		void StopLogging(){
			CancelInvoke ("LogMarker");
		}

		void UpdateAir(float distance_change){
			air -= 1;
			//todo: needs to be scaled

		}


		void LogMarker(){
			//create a new marker
			Marker m = new Marker ();
				m.position = view_Transform.position;
				m.rotation = view_Transform.rotation;
				m.timeCreated = Time.time;

			//set total_distance
			m.distance_change = 0;
			if (trail.Count > 0) {
				//difference from past marker
				m.distance_change = Vector3.Distance(trail[trail.Count - 1].position, m.position);
				total_distance += m.distance_change;
			}
			m.total_distance = total_distance;
			//total_idle


			UpdateAir (m.distance_change);
			m.air_level = air;

			//get phase from gamecontroller
			//phase
			//check phase
			//compare phase to previous marker
			//if phase1 != phase2
			if (false) {
				//mark keyframe
				m.key_frame = 1;
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

			//key frame

			m.export_marker_to_csv_line ();

			//add it to the list
			trail.Add (m);
		}

		void DrawDebugTrail(){
			if (trail.Count > 2) {
				for (int i = 0; i < trail.Count - 2; i++) {
					Color c = Color.red;
					if( Time.time - trail[i].timeCreated < 4)
						c = Color.yellow;
					if(Time.time - trail[i].timeCreated < 2)
						c = Color.green;
					Debug.DrawLine(	trail[i].position, trail[i+1].position, c);
					Debug.DrawRay( trail[i].position, trail[i].rotation * Vector3.forward );
				}
			}
		}

		public List<Marker> get_trail(){
			return trail;
		}

		public void export_all_markers_to_csv(){
			//export the current scenario / presentation profile

			//choose file

			//write header line

			//for each marker
			//call marker.export_marker_to_csv_line();
		}
	}

	public class Marker{
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
	

		public string export_marker_to_csv_line(){
			string csv_line = "";
			//add timestamp - 1
			csv_line += timeCreated.ToString () + ",";

			//add phase - 2
			csv_line += phase.ToString () + ",";

			//distance change  - 3
			csv_line += distance_change.ToString () + ",";

			//total distance traveled - 4
			csv_line += total_distance.ToString() + ",";

			//current position
//			public Vector3 position;
			
			//current direction
//			public Quaternion rotation;
			
			//targets hit
//			public int[] targets;
			

			
			//total time idle
			csv_line +=  total_idle.ToString() + ",";
			
			//phase distance traveled
			csv_line += phase_traveled.ToString() + ",";
			
			//phase time idle
			csv_line += phase_idle.ToString() + ",";
			
			//distance from target(s)
			csv_line += target_distance.ToString() + ",";
			
			//current air level
			csv_line += air_level.ToString() + ",";
			
			csv_line += mobility.ToString() + ",";
			
			//if first or last
			csv_line += key_frame.ToString() + "\n";

			Debug.Log (csv_line);

			return csv_line;
		}
	}


}

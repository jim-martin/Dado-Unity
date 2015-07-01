using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

namespace Data
{
	public class HistoricalData : MonoBehaviour {

		public float logIncrement = 1.0f;
		List<Marker> trail;
		Transform view_Transform;

		// Use this for initialization
		void Start () {
			trail = new List<Marker> ();

			//get the viewTransform (to log where the player was looking)
			DataComponent d = GetComponent<DataComponent> ();
			view_Transform = d.view_Transform;

			//log da shit
			StartLogging ();
		}

		void Update(){
			if (view_Transform == null) {
				DataComponent d = GetComponent<DataComponent> ();
				view_Transform = d.view_Transform;
			}

			DrawDebugTrail ();
		}

		void StartLogging(){
			InvokeRepeating ("LogMarker", 0.1f, logIncrement);
		}

		void StopLogging(){
			CancelInvoke ("LogMarker");
		}


		void LogMarker(){
			//create a new marker
			Marker m = new Marker ();
				m.position = view_Transform.position;
				m.rotation = view_Transform.rotation;
				m.timeCreated = Time.time;


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
	}

	public class Marker{
		public Vector3 position;
		public Quaternion rotation;
		public float timeCreated;
	}
}

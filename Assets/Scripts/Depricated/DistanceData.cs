using UnityEngine;
using Data;
using System.Collections;
using System.Collections.Generic;

namespace Data.Relative
{
	[RequireComponent(typeof (Transform))]
	public class DistanceData : DataObject 
	{

		Transform transform;

		void Start () 
		{
			transform = GetComponent<Transform> ();
		}

		void Update () 
		{
			PushUpdate ();
		}

		void PushUpdate()
		{
			float[] arr = getDistances ();
			if (subscribers != null) {
				subscribers (arr);
			}
		}

		public float[] getDistances()
		{
			List<float> distances = new List<float>();
			GameObject[] players = getPlayers ();
			
			foreach (GameObject p in players) {
				Vector3 vec = p.transform.position - transform.position;
				if( p.GetInstanceID() != this.gameObject.GetInstanceID()){
					distances.Add( Vector3.Magnitude(p.transform.position - transform.position));
				}
			}
			return distances.ToArray();
		}
	}
}

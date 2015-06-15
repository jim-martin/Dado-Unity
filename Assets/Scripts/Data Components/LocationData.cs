using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DataComponents
{
	public class LocationData
	{
		GameObject target;
		Transform t_Transform;

		public LocationData (GameObject target)
		{
			this.target = target;
			t_Transform = target.GetComponent<Transform> ();
		}

		public float[] getDistances()
		{
			List<float> distances = new List<float>();
			GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
			
			foreach (GameObject p in players) {
				Vector3 vec = p.transform.position - t_Transform.position;
				if( p.GetInstanceID() != target.GetInstanceID()){
					distances.Add( Vector3.Magnitude(p.transform.position - t_Transform.position));
				}
			}
			return distances.ToArray();
		}

		public Vector3[] getRelativePositions()
		{
			List<Vector3> positions = new List<Vector3>();
			GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
			
			foreach (GameObject p in players) {
				Vector3 vec = p.transform.position - t_Transform.position;
				if( p.GetInstanceID() != target.GetInstanceID()){
					positions.Add( t_Transform.InverseTransformPoint(p.transform.position));
				}
			}
			return positions.ToArray();
		}


		public Vector3[] getGlobalPositions()
		{
			List<Vector3> positions = new List<Vector3>();
			GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
			
			foreach (GameObject p in players) {
				Vector3 vec = p.transform.position - t_Transform.position;
				if( p.GetInstanceID() != target.GetInstanceID()){
					positions.Add( p.transform.position);
				}
			}
			return positions.ToArray();
		}

	}
}
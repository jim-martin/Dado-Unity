using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Data.Relative
{
	[RequireComponent(typeof (Transform))]
	public class DirectionData : DataObject 
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
			float[] arr = getDirections ();
			if (subscribers != null) {
				subscribers (arr);
			}
		}
		
		public float[] getDirections()
		{
			List<float> directions = new List<float>();
			GameObject[] players = getPlayers ();
			
			foreach (GameObject p in players) {
				Vector3 target = p.transform.position - transform.position;
				if( p.GetInstanceID() != this.gameObject.GetInstanceID()){
					float angle = Vector3.Angle(target, transform.forward);
					int angleDir;
					if (Vector3.Cross (target, transform.forward).y > 0) {
						angleDir = 1; //looking to the right of the target, pan to the left
					} else {
						angleDir = -1; //looking to the left of the target, pan to the right
					}

					directions.Add(angle*angleDir);
				}
			}
			return directions.ToArray();
		}
	}
}

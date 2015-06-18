using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Data
{
	public class DataComponent : MonoBehaviour
	{
		Transform t_Transform;

		void Start(){
			t_Transform = GetComponent<Transform> ();
		}

		public float getDirection()
		{
			float direction;
			GameObject target = getTarget ();

			Vector3 tRot = target.transform.position - transform.position;

			float angle = Vector3.Angle(target.transform.position, transform.forward);
			int angleDir;
			if (Vector3.Cross (target.transform.position, transform.forward).y > 0) {
				angleDir = 1; //looking to the right of the target, pan to the left
			} else {
				angleDir = -1; //looking to the left of the target, pan to the right
			}
				
			direction = angle*angleDir;
			return direction;
		}
		
		public float getDistance()
		{
			float distance;
			GameObject target = getTarget ();
		
			Vector3 vec = target.transform.position - t_Transform.position;
			distance = Vector3.Magnitude (target.transform.position - t_Transform.position);
			return distance;
		}

		public Vector3 getRelativePosition()
		{
			GameObject target = getTarget ();
			Vector3 vec = target.transform.position - t_Transform.position;
			return vec;
		}


		public Vector3 getGlobalPosition()
		{
			GameObject target = getTarget ();
			Vector3 vec = target.transform.position;
			return vec;
		}

		public GameObject getTarget()
		{
			GameObject target =  GameObject.FindGameObjectWithTag ("Target");
			if (target == null) {
				Debug.LogWarning ("Target not found, assign something in the scene to the 'Target' tag to begin tracking.");
			}
			return target;
		}

	}
}
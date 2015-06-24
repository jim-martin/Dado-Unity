using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Data
{
	public class DataComponent : MonoBehaviour
	{
		Transform t_Transform;

		public Transform view_Transform;

		void Start(){
			t_Transform = GetComponent<Transform> ();

			if (view_Transform == null) {
				view_Transform = t_Transform;
			}
		}

		public float getDirectionWithView(){
			float direction;
			GameObject target = getTarget ();
			
			Vector3 tRot = target.transform.position - view_Transform.position;
			
			Vector2 target_vec = new Vector2 (getRelativePostitionWithView().x, getRelativePostitionWithView().z);
			//			Debug.Log (target_vec);
			Vector2 facing_vec = new Vector2 (view_Transform.forward.x, view_Transform.forward.z);
			//			Debug.Log (transform.forward);
			//			Debug.Log (facing_vec);
			
			//			float angle = Vector3.Angle(getRelativePosition(), transform.forward);
			float angle = Vector2.Angle(target_vec, facing_vec);
			//			Debug.Log (angle);
			int angleDir = 1;
			if (Vector3.Cross (getRelativePostitionWithView(), view_Transform.forward).y > 0) {
				angleDir = 1; //looking to the right of the target, pan to the left
			} else {
				angleDir = -1; //looking to the left of the target, pan to the right
			}
			
			direction = angle*angleDir;
			//Debug.Log (direction);
			return direction;
		}


		public Vector3 getRelativePostitionWithView(){
			GameObject target = getTarget ();
			Vector3 vec = target.transform.position - view_Transform.position;
			return vec;
		}

		public float getDirection()
		{
			float direction;
			GameObject target = getTarget ();

			Vector3 tRot = target.transform.position - transform.position;

			Vector2 target_vec = new Vector2 (getRelativePosition().x, getRelativePosition().z);
//			Debug.Log (target_vec);
			Vector2 facing_vec = new Vector2 (transform.forward.x, transform.forward.z);
//			Debug.Log (transform.forward);
//			Debug.Log (facing_vec);

//			float angle = Vector3.Angle(getRelativePosition(), transform.forward);
			float angle = Vector2.Angle(target_vec, facing_vec);
//			Debug.Log (angle);
			int angleDir = 1;
			if (Vector3.Cross (getRelativePosition(), transform.forward).y > 0) {
				angleDir = 1; //looking to the right of the target, pan to the left
			} else {
				angleDir = -1; //looking to the left of the target, pan to the right
			}

			direction = angle*angleDir;
			//Debug.Log (direction);
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
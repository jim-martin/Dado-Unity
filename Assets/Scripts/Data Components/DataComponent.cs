﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using Data;

namespace Data
{
	public class DataComponent : MonoBehaviour
	{
		Transform t_Transform;
		public Transform view_Transform;

		void Start(){
			t_Transform = GetComponent<Transform> ();

			Time.timeScale = 1;

//			Debug.Log (t_Transform);

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
		
			Vector3 vec = target.transform.position - transform.position;
			distance = Vector3.Magnitude (target.transform.position - transform.position);
			return distance;
		}

		public Vector3 getRelativePosition()
		{
			GameObject target = getTarget ();
			Vector3 vec = target.transform.position - transform.position;
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
			GameObject target =  GameObject.FindGameObjectWithTag ("p3 target");
			if (target == null) {
				Debug.LogWarning ("Target not found, assign something in the scene to the 'Target' tag to begin tracking.");
			}
			return target;
		}

		//returns list of all GameObjects tagged as "team"
		//changed to array from list because FindGameObjectsWithTag already returns an array
		public GameObject[] getTeam(){
			GameObject[] gos;
			gos = GameObject.FindGameObjectsWithTag ("Team");
			return gos;
		}

		//returns direction to given GameObject
		public float getDirection(GameObject myGO){
			float direction;
			GameObject target = myGO;
			
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

		public float getDistance(GameObject myGO)
		{
			float distance;
			GameObject target = myGO;
			
			Vector3 vec = target.transform.position - transform.position;
			distance = Vector3.Magnitude (target.transform.position - transform.position);
			return distance;
		}

		//returns distance to given Marker
		public float getDistance(Marker myGO){
			float distance;
			Marker target = myGO;
			
			Vector3 vec = target.position - t_Transform.position;
			distance = Vector3.Magnitude (target.position - t_Transform.position);
			return distance;
		}

		//returns direction to given Marker
		public float getDirection(Marker myGO){
			float direction;
			Marker target = myGO;
			
			Vector3 tRot = target.position - transform.position;
			
			float angle = Vector3.Angle(target.position, transform.forward);
			int angleDir;
			if (Vector3.Cross (target.position, transform.forward).y > 0) {
				angleDir = 1; //looking to the right of the target, pan to the left
			} else {
				angleDir = -1; //looking to the left of the target, pan to the right
			}
			
			direction = angle*angleDir;
			return direction;
		}

		public List<Marker> get_trail(GameObject go){
			//for GO
			//get HistoricalData
			Debug.Log (go);
			HistoricalData go_history = go.GetComponent<HistoricalData> ();
			return go_history.get_trail();
		}

		//given a GameObject
		//return different in height between the player and the GameObject
		//positive value indicates that the target is above the player
		//negative value indicates that the target is below the player
		public float getHeightDifference(GameObject go){
			float distance;
			GameObject target = go;
			distance =  t_Transform.position.y - target.transform.position.y;
			return distance;
		}

		public float getHeightDifference(Marker go){
			float distance;
			Marker target = go;
			distance =  t_Transform.position.y - target.position.y;
			return distance;
		}


		//trail methods need testing
		//given a trail
		//return direction to the closest marker
		public float getDirectionToTrail(List<Marker> trail){
			Marker closestMarker = trail[0];
			float curDistance = getDistance (closestMarker);

			foreach (Marker mark in trail) {
				if(getDistance(mark) < curDistance){
					curDistance = getDistance (mark);
					closestMarker = mark;
				}
			}

			return getDirection (closestMarker);
		}

		//given a trail
		//return distance to the closest marker
		public float getDistanceToTrail(List<Marker> trail){
			Marker closestMarker = trail[0];
			float curDistance = getDistance (closestMarker);
			
			foreach (Marker mark in trail) {
				if(getDistance(mark) < curDistance){
					curDistance = getDistance (mark);
					closestMarker = mark;
				}
			}
			
			return curDistance;
		}


	}
}
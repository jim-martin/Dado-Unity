using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(ProfileComponent))]
public class ProfileComponentEditor : Editor {

	public override void OnInspectorGUI(){

		DrawDefaultInspector ();

		ProfileComponent p = (ProfileComponent)target;

		if (GUILayout.Button ("Save Profile")) {
			p.saveProfile();
		}
		if (GUILayout.Button ("Load Profile")) {
			p.loadProfile();
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(ProfileComponent))]
public class ProfileComponentEditor : Editor {

	public override void OnInspectorGUI(){

		DrawDefaultInspector ();

		ProfileComponent p = (ProfileComponent)target;

		string saveFileName = "default";
		EditorGUILayout.TextField("Save File : ", saveFileName);
		if (GUILayout.Button ("Save Profile to " + saveFileName + ".dat")) {
			p.saveProfile( saveFileName );
		}

		string loadFileName = "default";
		EditorGUILayout.TextField("Load File : ", loadFileName);
		if (GUILayout.Button ("Load Profile from " + loadFileName + ".dat")) {
			p.loadProfile( loadFileName );
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(ProfileComponent))]
public class ProfileComponentEditor : Editor {

	public override void OnInspectorGUI(){

		DrawDefaultInspector ();

		ProfileComponent p = (ProfileComponent)target;
				
		p.saveFileName = EditorGUILayout.TextField("Save File : ", p.saveFileName);
		if (GUILayout.Button ("Save Profile to " + p.saveFileName + ".dat")) {
			p.saveProfile( p.saveFileName );
		}

		p.loadFileName = EditorGUILayout.TextField("Load File : ", p.loadFileName);
		if (GUILayout.Button ("Load Profile from " + p.loadFileName + ".dat")) {
			p.loadProfile( p.loadFileName );
		}
	}
}

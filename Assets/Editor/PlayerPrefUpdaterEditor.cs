using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(PlayerPrefUpdater))]
public class PlayerPrefUpdaterEditor : Editor {

	public override void OnInspectorGUI(){

		DrawDefaultInspector ();

		PlayerPrefUpdater p = (PlayerPrefUpdater)target;

		if (GUILayout.Button ("Set PlayerPrefs")) {
			p.UpdatePrefs();
		}

		if (GUILayout.Button ("Save Score for Player : " + p.playerName)){
			p.SaveScore();
		}

	}
}

using UnityEngine;
using System.Collections;
using UnityEditor;
using Data;

[CustomEditor(typeof(HistoricalData))]
public class HistoricalDataComponentEditor : Editor {

	public override void OnInspectorGUI(){

		DrawDefaultInspector ();

		HistoricalData h = (HistoricalData)target;

		if (GUILayout.Button ("Export markers to CSV")) {
			if(Application.isPlaying && h.get_trail() != null){
				h.export_all_markers_to_csv();
			}else{
				Debug.Log("Can't export points unless the player is running and a trail is being generated");
			}
		}
	}
	
}

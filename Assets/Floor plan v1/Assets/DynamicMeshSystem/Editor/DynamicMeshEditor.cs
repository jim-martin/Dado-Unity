using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(DynamicMesh))]
public class DynamicMeshEditor : Editor
{	
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		DynamicMesh DScript = (DynamicMesh)target;
		EditorGUILayout.HelpBox ("Warning: Updating the mesh in the Inspector will be permanent however you can use the Reset button. To make temporary changes use UpdateMesh() Ingame. To begin click ''Build Arrays''.", MessageType.Warning);

		GUILayout.BeginHorizontal ();
			if(GUILayout.Button("Build Arrays"))
			{
				DScript.EditorBuild();
				EditorUtility.SetDirty(DScript);
				for (int i = 0; i < DScript.SinglesCount; ++i) { //For each unqiue vertex, instantiate a yellow cube.
					DScript.Singles[i].AddComponent<IconSelection>();
				}
				DScript.GizmosOn = true;
			}
			if(GUILayout.Button("Update Mesh"))
			{
				DScript.EditorUpdateMesh();
			}
			if(GUILayout.Button("Reset Mesh"))
			{
				DScript.EditorResetMesh();
				for (int i = 0; i < DScript.SinglesCount; ++i) { //For each unqiue vertex, instantiate a yellow cube.
					DScript.Singles[i].AddComponent<IconSelection>();
				}
				DScript.GizmosOn = true;
			}
			if(GUILayout.Button("Clear"))
			{
				DScript.GizmosOn = false;
				DScript.UpdateOn = false;
				DestroyImmediate(DScript.gameObject.GetComponent<RealTimeEditorUpdate>());
				DScript.EditorClear();
			}
		GUILayout.EndHorizontal ();
		EditorGUILayout.HelpBox ("To set the size of the vertex gizmo select ''Gizmos'' in the Scene View and adjust the slider.", MessageType.Info);
		GUILayout.BeginHorizontal ();
			if(GUILayout.Button("Gizmos On/Off"))
			{
			//Debug.Log(GizmosOn);
				if(!DScript.GizmosOn){
					DScript.GizmosOn = true;
				//Debug.Log("DD");
					for (int i = 0; i < DScript.SinglesCount; ++i) { //For each unqiue vertex, instantiate a yellow cube.
						DScript.Singles[i].AddComponent<IconSelection>();
					}
				}
				else{
					DScript.GizmosOn = false;
					for (int i = 0; i < DScript.SinglesCount; ++i) { //For each unqiue vertex, instantiate a yellow cube.
						DestroyImmediate(DScript.Singles[i].GetComponent<IconSelection>());
					}
				}
			}
			if(GUILayout.Button("Real-Time Update On/Off"))
			{
				if(DScript.UpdateOn == false){
					DScript.UpdateOn = true;
					RealTimeEditorUpdate mvar = DScript.gameObject.AddComponent<RealTimeEditorUpdate>();
					mvar.mMesh = DScript;
					mvar.EditorUpdate = true;
					return;
				}
				if(DScript.UpdateOn == true){
					DScript.UpdateOn = false;
					DestroyImmediate(DScript.gameObject.GetComponent<RealTimeEditorUpdate>());
				}
			}
		GUILayout.EndHorizontal ();
	}
}
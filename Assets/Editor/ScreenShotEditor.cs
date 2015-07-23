using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(ScreenShotComponent))]
public class ScreenShotEditor : Editor {
	
	public override void OnInspectorGUI(){
		
		DrawDefaultInspector ();
		
		ScreenShotComponent p = (ScreenShotComponent)target;

		if (GUILayout.Button ("Take Screenshot")) {
			p.TakeScreenShot();
		}

		if (GUILayout.Button ("Reset Count")) {
			p.ResetCount();
		}
	}
}

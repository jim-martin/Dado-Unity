using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class RealTimeEditorUpdate : MonoBehaviour {
	public bool EditorUpdate = false;
	public DynamicMesh mMesh;

	void Update () {
		if (EditorUpdate) {
			mMesh.EditorUpdateMesh();
		}
	}
}

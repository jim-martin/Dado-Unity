using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Demo : MonoBehaviour {

	public Transform Prefab;
	public DynamicMesh[] mDynamicMesh;

	// Use this for initialization
	void Start () {
		for (int c = 0; c<mDynamicMesh.Length; ++c) { //How many Dynamic Meshes set in the inspector do we have ?
			for (int i = 0; i<mDynamicMesh[c].SinglesCount; ++i) { //For each unqiue vertex, instantiate a yellow cube.
				Transform mVertex = Instantiate(Prefab,mDynamicMesh[c].Singles[i].transform.position,Quaternion.identity) as Transform; //Instantiates a yellow cube to the vertex position.
				VBinder mBinder = mVertex.gameObject.AddComponent<VBinder>();
				mBinder.Target = mDynamicMesh[c].Singles[i]; //Bind The Vertex To The Yellow Cube
			}
		}
	}
	
	// Update is called once per frame
	bool Selected = false; //Do we have a selection ?
	GameObject mSelection; //Which Cube is selected ?
	void Update () {
		if(Selected){
			float xpos = Input.GetAxis ("Mouse X") * 0.5f;
			float ypos = Input.GetAxis ("Mouse Y") * 0.5f;
			mSelection.transform.position = new Vector3(mSelection.transform.position.x + xpos, mSelection.transform.position.y + ypos, mSelection.transform.position.z);
			for (int c = 0; c<mDynamicMesh.Length; ++c) {
				mDynamicMesh[c].UpdateMesh();
			}
		}

		if (Input.GetButtonDown ("Fire1")) {
			Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit mHit;
			if(Physics.Raycast(mRay,out mHit)){
				if(mHit.collider.tag == "Cube"){ //if we hit a yellow cube
					Selected = true;
					mSelection = mHit.collider.gameObject;
				}
			}
		}

		if (Input.GetButtonUp ("Fire1")) {
			Selected = false; //remove selection when the mouse button is released
		}
	}
}

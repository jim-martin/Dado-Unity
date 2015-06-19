using UnityEngine;
using System.Collections;

public class Demo2 : MonoBehaviour {

	// Use this for initialization
	public GameObject VertexSelection1;
	public GameObject VertexSelection2;
	public GameObject VertexSelection3;
	public GameObject VertexSelection4;
	DynamicMesh mMesh;

	void Start () {
		mMesh = gameObject.GetComponent<DynamicMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y - 0.1f, transform.eulerAngles.z);
		if (Input.GetButton ("Fire1")) {
			VertexSelection1.transform.position += -VertexSelection1.transform.forward * 0.1f;
			VertexSelection2.transform.position += -VertexSelection1.transform.forward * 0.1f;
			VertexSelection3.transform.position += -VertexSelection1.transform.forward * 0.1f;
			VertexSelection4.transform.position += -VertexSelection1.transform.forward * 0.1f;
			mMesh.UpdateMesh(); //Updates the mesh after moving the vertices
		}
		if (Input.GetButton ("Fire2")) {
			VertexSelection1.transform.position += VertexSelection1.transform.forward * 0.1f;
			VertexSelection2.transform.position += VertexSelection1.transform.forward * 0.1f;
			VertexSelection3.transform.position += VertexSelection1.transform.forward * 0.1f;
			VertexSelection4.transform.position += VertexSelection1.transform.forward * 0.1f;
			mMesh.UpdateMesh(); //Updates the mesh after moving the vertices
		}
	}
}

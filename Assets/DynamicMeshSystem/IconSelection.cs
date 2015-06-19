using UnityEngine;
using System.Collections;

public class IconSelection : MonoBehaviour {
	void OnDrawGizmos () {
		Gizmos.DrawIcon (transform.position, "Vertex.png", true);
	}
}

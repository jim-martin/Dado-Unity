using UnityEngine;
using System.Collections;
using Data;

public class EnableOnSubscribe : MonoBehaviour {

	GameController gc;
	MeshRenderer m;

	Phase p;

	// Use this for initialization
	void Start () {

		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		m = GetComponent<MeshRenderer>();

		p = gc.getPhaseByName("exit");
		p.StartPhase += EnableMeshRenderer;
	
	}
	
	void EnableMeshRenderer(){

		m.enabled = true;

	}
}

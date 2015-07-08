using UnityEngine;
using System.Collections;

public class DistanceCull : MonoBehaviour {

	public float maxDist = 20.0f;

	GameObject player;
	EllipsoidParticleEmitter e;


	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");
		e = GetComponent<EllipsoidParticleEmitter> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player == null) {
			try{
				player = GameObject.FindGameObjectWithTag("Player");
			}catch(UnityException e){
				Debug.Log(e);
				return;
			}
		}

		float dist = Vector3.Distance (player.transform.position, transform.position);

		if (dist > maxDist) {
			e.enabled = false;
		} else {
			e.enabled = true;
		}
	}
}

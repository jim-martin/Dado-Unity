using UnityEngine;
using System.Collections;

public class TriggerTarget : MonoBehaviour {

	public bool isTriggered = false;
	public Texture2D tex;

	public int targetValue = 100;

	MeshRenderer mesh;

	void Awake (){
		mesh = GetComponent<MeshRenderer> ();
	}

	void OnCollisionEnter( Collision col ){

		if ((col.gameObject.tag == "Player" 
		    || col.gameObject.tag == "push")
		    && mesh.enabled) {
			mesh.material.mainTexture = tex;

			if(!isTriggered)UpdateScore();
			isTriggered = true;
		}

	}

	void OnTriggerEnter( Collider other ){

		if ((other.gameObject.tag == "Player" 
		    || other.gameObject.tag == "push")
		    && mesh.enabled) {
			isTriggered = true;
		}
	}

	void UpdateScore(){

		int s = PlayerPrefs.GetInt("CurrentPlayerScore", 0);
		s += targetValue;

		Debug.Log ("** SCORE ** : " + s);
		PlayerPrefs.SetInt("CurrentPlayerScore", s);

	}
}

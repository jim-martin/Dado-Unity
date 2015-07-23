using UnityEngine;
using System.Collections;

public class DisableOnCondition : MonoBehaviour {

	public int condition = 0;

	GameController gc;

	// Use this for initialization
	void Start () {

		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	
	}

	void Update(){
		if(gc.getCondition() != condition){
			gameObject.SetActive(false);
		}else{
			gameObject.SetActive(true);
		}
	}

}

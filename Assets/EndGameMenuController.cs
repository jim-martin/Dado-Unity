using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGameMenuController : MonoBehaviour {

	GameController gc;
	Text t;

	void Awake(){
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		t = GameObject.Find("score").GetComponent<Text>();
	}

	// Use this for initialization
	void Start () {

		gc.EndGame += ShowMenu;
		gameObject.SetActive(false);
	
	}
	
	void ShowMenu(){

		int s = PlayerPrefs.GetInt("CurrentPlayerScore", 0);
		t.text = "SCORE : " + s;
		gameObject.SetActive(true);

	}
}

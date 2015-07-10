using UnityEngine;
using System.Collections;

public class PracticeGameController : MonoBehaviour {

	GameController gc;

	void Awake (){

		//check the playerprefs to make sure that it should be on a practice session

		//maybe do a popup that asks if you want to load the appropriate #stage, or change the prefs file.
	}

	void Start (){
//		gc = GetComponent<GameController>();
//		gc.StartGame();

		Time.timeScale = 1;
	}

	public void LoadNextScene(){

//		int j = PlayerPrefs.GetInt( "testStep" );
//		PlayerPrefs.SetInt( "testStep" , j+1 );
//		Debug.Log(PlayerPrefs.GetInt( "testStep" ));

		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}
}

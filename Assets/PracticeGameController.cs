using UnityEngine;
using System.Collections;

public class PracticeGameController : MonoBehaviour {

	GameController gc;

	void Start (){
//		gc = GetComponent<GameController>();
//		gc.StartGame();

		Time.timeScale = 1;
	}

	public void LoadNextScene(){
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}
}

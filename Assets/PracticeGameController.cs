using UnityEngine;
using System.Collections;

public class PracticeGameController : MonoBehaviour {

	public void LoadNextScene(){
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}
}

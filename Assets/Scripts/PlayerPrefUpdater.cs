using UnityEngine;
using System.Collections;

public class PlayerPrefUpdater : MonoBehaviour {


	public int testStep = 0;
	public int totalTestSteps = 4;
	public string customProfile = "control";
	public string playerName = "default";


	public void UpdatePrefs(){

		PlayerPrefs.SetInt("testStep", testStep);
		PlayerPrefs.SetInt("totalTestSteps", totalTestSteps);
		PlayerPrefs.SetString("customProfile", customProfile);

	}

	public void SaveScore(){

		int s = PlayerPrefs.GetInt("CurrentPlayerScore", 0);
		PlayerPrefs.SetInt( playerName, s);
		Debug.Log("Saved Score for Player : " + playerName + " - **" + s + "**");
	}
}

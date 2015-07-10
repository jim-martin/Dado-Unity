using UnityEngine;
using System.Collections;

public class PlayerPrefUpdater : MonoBehaviour {


	public int testStep = 0;
	public int totalTestSteps = 4;
	public string customProfile = "control";


	public void UpdatePrefs(){

		PlayerPrefs.SetInt("testStep", testStep);
		PlayerPrefs.SetInt("totalTestSteps", totalTestSteps);
		PlayerPrefs.SetString("customProfile", customProfile);

	}
}

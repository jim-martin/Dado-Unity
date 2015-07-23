using UnityEngine;
using System.Collections;

public class ScreenShotComponent : MonoBehaviour {
	
	public void TakeScreenShot(){

		int shot = PlayerPrefs.GetInt("ScreenShotCount", 0);
		Debug.Log("Taking Screenshot...." + shot);
		
		Application.CaptureScreenshot(@"./Assets/ScreenShots/Screen_" + shot + ".png");
		shot++;
		PlayerPrefs.SetInt("ScreenShotCount", shot);
		Time.timeScale = 0;
	}

	public void ResetCount(){
		PlayerPrefs.SetInt("ScreenShotCount", 0);
		Debug.Log("Resetting Count....");
	}
}

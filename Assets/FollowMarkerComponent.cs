using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

public class FollowMarkerComponent : MonoBehaviour {

	public TextAsset import_csv;

	int currentStep = 0;

	HistoricalData hdata;
	List<Marker> trail;

	// Use this for initialization
	void Start () {

			Invoke ("CheckForData", 1);

	}

	void Update(){
		//figure out lerp
	}

	public List<Marker> GetTrail(){
		return trail;
	}

	void CheckForData(){

//		Debug.Log ("Checking for data....");

		if (hdata == null) {
			try{
				hdata = GameObject.FindGameObjectWithTag("Player").GetComponent<HistoricalData>();
			}
			catch{
				Invoke ("CheckForData", 1);
				return;
			}
		}

		if(import_csv != null){

			trail = hdata.import_csv_into_markers(import_csv);

		}else{

			if (trail == null) {
				try {
					trail = hdata.get_trail ();
				} catch (UnityException e) {
					Invoke ("CheckForData", 1);
					Debug.LogWarning (e);
					return;
				}
			}
		}


		

		if (trail.Count < 2) {
			Invoke("CheckForData", 1);
			return;
		}		

		transform.position = trail[0].position;
		transform.rotation = trail[0].rotation;
		InvokeRepeating("Step", hdata.logIncrement, hdata.logIncrement);
	}

	void Step(){
		currentStep++;
		if(currentStep < trail.Count){
			transform.position = trail [currentStep].position + (Vector3.down * 0.5f);
			transform.rotation = trail [currentStep].rotation;
		}
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Data;

public class FireTrail : MonoBehaviour {

	public TextAsset import_csv;
	public Object firePrefab;

	public Vector3 upperBound;
	public Vector3 lowerBound;

	public Vector3 intensityStep;

	List<Marker> trail;
	List<GameObject> firePoints;

	private void Awake (){

		trail = import_csv_into_markers(import_csv);
		firePoints = new List<GameObject>();

	}

	public void Start(){
		CreateFire();
		Invoke ("Disable", 2);
	}

	public void FixedUpdate(){
		transform.position = transform.position + intensityStep;
	}

	private void CreateFire(){
		float i = 0.0f;
		foreach(Marker m in trail){
			//add a fire object at that marker pos, keep a list of them too?
			GameObject fp = (GameObject)Instantiate(firePrefab, m.position, m.rotation);
			fp.transform.parent = transform;
			firePoints.Add(fp);

			//adjust fire's y pos based on it's distance from the fire and/or it's step on the path
			Vector3 delta = Vector3.Lerp(lowerBound, upperBound, (i/trail.Count));
			fp.transform.position = fp.transform.position + delta;

			//adjust the fire's colors based on distance from fire

			//how to address the spread of the particles....
				//BAKE SCALE - 360 raycast to see the space, then adjust the spread of particles to fit the space/add more emitters

			i += 1.0f;
		}
	}

	private List<Marker> import_csv_into_markers (TextAsset file){
		
		
		string[] lines = file.text.Split ("\n" [0]);
		List<Marker> imported_markers = new List<Marker> ();
		for (int i = 1; i < lines.Length - 1; i++) { //first line is header, last line is a blank line
			string line = lines [i];
			Marker new_marker = new Marker ();
			new_marker.import_from_csv_line (line);
			imported_markers.Add (new_marker);
		}
		
		return imported_markers;
	}

	void OnTriggerEnter( Collider c ){
		if(c.gameObject.tag == "Player"){
			Debug.Log("Player in box");
			foreach( Object o in firePoints ){
				GameObject go = (GameObject)o;
				go.SetActive(true);
			}
		}
	}

	void OnTriggerExit( Collider c ){
		if( c.gameObject.tag == "Player"){
			Debug.Log("Player not in box");
			foreach( Object o in firePoints ){
				GameObject go = (GameObject)o;
				go.SetActive(false);
			}

		}
	}

	private void Disable(){
		foreach( Object o in firePoints ){
			GameObject go = (GameObject)o;
			go.SetActive(false);
		}
	}

}

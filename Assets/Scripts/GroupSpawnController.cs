using UnityEngine;
using System.Collections;
using System;

public class GroupSpawnController : MonoBehaviour {

	public string tag;
	public int groupSize;
	public GameObject prefab;

	GameObject[] spawns;

	void Start () {

		spawns = GameObject.FindGameObjectsWithTag(tag);

		if(groupSize > spawns.Length){
			Debug.Log("Not enough spawn locations for everyone!");
			groupSize = spawns.Length;
		}

		for(int j = 0; j < groupSize; j++){

			//choose the location of the next spawn
 			int i = (int)Mathf.Floor(UnityEngine.Random.Range(0, spawns.Length));

			//spawn the chosen prefab
			GameObject go = (GameObject)Instantiate(prefab, spawns[i].transform.position, Quaternion.identity);
			go.transform.parent = spawns[i].transform;

			//remove the chosen entry fron the list of possible spawns
			GameObject[] s = new GameObject[spawns.Length - 1];
			Array.Copy(spawns, 0, s, 0, i);
			Array.Copy (spawns, i+1, s, i, spawns.Length - i - 1);			
			spawns = s;


		}
	
	}

}

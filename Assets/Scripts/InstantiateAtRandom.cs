using UnityEngine;
using System.Collections;


public class InstantiateAtRandom : MonoBehaviour
{
	public Transform ObjectToInstantiate;
	public string spawnTargetTag;
	
	public bool InstantiateSceneObjects = false;
	public bool InstantiateOnePerRoom = false;
	
	private GameObject newObj;   // not used but to show that you get the GO as return
	
	public void OnJoinedRoom()
	{
		bool unique = CheckUnique();
		if(InstantiateOnePerRoom && !unique){
			return;
		}

		GameObject target;
		GameObject[] targets = GameObject.FindGameObjectsWithTag(spawnTargetTag);

		if(targets.Length < 1){
			Debug.LogError("no spawn markers with tag : " + spawnTargetTag + "were found.");
		}
		target = targets[Random.Range(0,targets.Length)];

		Vector3 pos = target.transform.position;
		pos.x += PhotonNetwork.player.ID;
		
		if (!InstantiateSceneObjects)
		{
			
			newObj = PhotonNetwork.Instantiate(ObjectToInstantiate.name, pos, Quaternion.identity, 0, null);
			
			
			// anything you do with newObj locally is not reflected on the other clients.
			// you can add a script to the Prefab to do some instantiation in Awake() and you can call RPCs on newObj now.
		}
		else
		{
			newObj = PhotonNetwork.InstantiateSceneObject(ObjectToInstantiate.name, pos, Quaternion.identity, 0, null);
			//PhotonView pv = newObj.GetComponent<PhotonView>() as PhotonView;
			//Debug.Log(pv.ownerId + " " + pv.viewID);
		}
	}

	public bool CheckUnique(){
		GameObject g = GameObject.FindGameObjectWithTag(ObjectToInstantiate.tag);
		if(g == null){
			return true;
		}else{
			return false;
		}
	}
}
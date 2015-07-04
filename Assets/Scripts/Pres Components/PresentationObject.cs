using UnityEngine;
using System.Collections;
using Data;

public class PresentationObject : MonoBehaviour {

	public DataObject data;
	public float[] dataInput;

	public void onDataUpdate( float[] output )
	{
		dataInput = output;
	}

	public void Subscribe()
	{
		data = GetComponent<DataObject> ();
		data.subscribers += onDataUpdate; 
	}
}

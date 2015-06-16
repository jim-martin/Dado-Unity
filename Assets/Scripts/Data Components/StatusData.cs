using UnityEngine;
using System.Collections;

public class StatusData
{
	GameObject target;

	public StatusData(GameObject target)
	{
		this.target = target;
	}

	public GameObject[] getPlayers()
	{
		return GameObject.FindGameObjectsWithTag ("Player");
	}

}

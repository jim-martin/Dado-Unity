using UnityEngine;
using System.Collections;

namespace Data
{
	public class DataObject: MonoBehaviour 
	{
		public delegate void Subscribers(float[] output);
		public Subscribers subscribers;

		void Start()
		{
		}

		void Update()
		{
		}

		void PushUpdate()
		{
		}

		public GameObject[] getPlayers()
		{
			return GameObject.FindGameObjectsWithTag ("Player");
		}
		
	}
}

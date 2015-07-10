using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Reflection;

public class ProfileComponent : MonoBehaviour {

	public KeyCode key;
	public string saveFileName;
	public string loadFileName;

	[SerializeField]
	bool pull = false;

	GameController gc;


	void Awake(){

		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

		if(pull){

			//pull doesn't need anything initilized on awake

		}else{

			//subscribe to stepphase() on gc
			gc.StepPhase += loadPhaseProfiles;

		}

	}

	void Update(){

		if(pull){

			//check keydown
			if(Input.GetKeyDown(key)){
				loadPhaseProfiles();
			}

			//check keyup
			if(Input.GetKeyUp(key)){
				loadProfile("control");
			}
			
		}else{

			//!pull doesnt' need anything per frame	
			
		}

	}

	public void TogglePull(){

		pull = !pull;

		if(pull){

			//unsubscribe the loadphaseprofiles function since we want it to be off all the time with pull
			gc.StepPhase -= loadPhaseProfiles;
			
		}else{

			//subscribe the loadphaseprofiles function
			gc.StepPhase += loadPhaseProfiles;
		}

	}

	void loadPhaseProfiles(){

		//split profiles in condition by ','
		string[] toLoad = gc.getPhaseObject().profiles[gc.getCondition()].Split(',');
		
		//load 1st profile
		loadProfile( toLoad[0]);
		
		//load_add the rest, if any
		for(int i = 1; i < toLoad.Length; i++){
			loadProfile_Add( toLoad[i]);
		}

	}


	public void saveProfile( string filename ){		
		
		//create serializer
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (@"./Assets/logs/profiles" + "/" + filename + ".dat");
		
		//get components (of type monobehavior)
		Profile p = Introspect ();
		
		//serialize profile class and export result
		bf.Serialize (file, p);
		file.Close ();
	}
	
	public void loadProfile( string filename ){
		
		Profile p;

		//find serialized profile on default datapath
		if (File.Exists (@"./Assets/logs/profiles" + "/" + filename + ".dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (@"./Assets/logs/profiles" + "/" + filename + ".dat", FileMode.Open);
			p = (Profile)bf.Deserialize (file);
			file.Close ();
			
			//adjust "profile" Class settings
			for (int i = 0; i < p.entries.Length; i++) {
				
				//				Debug.Log(p.entries[i].component);
				//				Debug.Log("\t" + p.entries[i].key);
				//				Debug.Log("\t" + p.entries[i].value);
				
				Component c = GetComponent (p.entries [i].component);
				c.GetType ().GetField (p.entries [i].key).SetValue (c, p.entries [i].value);
			}			
		} else {
			Debug.Log ("PROFILE DATA" + filename + ".dat NOT FOUND");
		}
	}

	public void loadProfile_Add( string filename ){

		Profile p;
		
		//find serialized profile on default datapath
		if (File.Exists (@"./Assets/logs/profiles" + "/" + filename + ".dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (@"./Assets/logs/profiles" + "/" + filename + ".dat", FileMode.Open);
			p = (Profile)bf.Deserialize (file);
			file.Close ();
			
			//adjust "profile" Class settings
			for (int i = 0; i < p.entries.Length; i++) {
				
				//				Debug.Log(p.entries[i].component);
				//				Debug.Log("\t" + p.entries[i].key);
				//				Debug.Log("\t" + p.entries[i].value);

				//only change positive values stored by the profile
				Component c = GetComponent (p.entries [i].component);
				if( p.entries [i].value ){
					c.GetType ().GetField (p.entries [i].key).SetValue (c, p.entries [i].value);
				}
			}		
		} else {
			Debug.Log ("PROFILE DATA" + filename + ".dat NOT FOUND");
		}
	}
	
	Profile Introspect(){
		
		Profile p = new Profile ();
		List<ProfileEntry> list = new List<ProfileEntry>();
		
		//compontents on the local cameobject
		Component[] components = GetComponents(typeof(MonoBehaviour));
		
		for (int i = 0; i < components.Length; i++) {
			
			Component c = components[i];
			if(c == null){
				Debug.LogWarning( "Empty script attatched in position " + i);
			}else{
				Type t = c.GetType();
				//Debug.Log("Component Type : " + t.Name);

				//ignore the profilecomponents settings itself in the profile
				if( t != this.GetType()){
				
					System.Reflection.FieldInfo[] fieldInfo = t.GetFields();
					foreach (System.Reflection.FieldInfo info in fieldInfo){

						//Debug.Log("\tType in field:  " + info.GetValue(c).GetType());

						if( info.GetValue(c).GetType() == typeof(bool)){

							ProfileEntry e = new ProfileEntry();
							e.component = t.FullName;
							e.key = info.Name;
							e.value = (Boolean)info.GetValue(c);

							list.Add(e);

						}
					}
					
				}

				System.Reflection.PropertyInfo[] propertyInfo = t.GetProperties();
				foreach (System.Reflection.PropertyInfo info in propertyInfo){
				}
			}
		}
		
		p.entries = list.ToArray();
		return p;
	}
	
	[Serializable]
	class Profile{
		public ProfileEntry[] entries;
	}
	
	[Serializable]
	class ProfileEntry{
		public string component;
		public string key;
		public Boolean value;
	}
}
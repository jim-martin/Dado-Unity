using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using UnityEditor;
using System.Reflection;

public class ProfileComponent : MonoBehaviour {

	public string saveFileName = "default";
	public string loadFileName = "default";

	public void saveProfile( string filename ){
		
		
		
		//create serializer
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/" + filename + ".dat");
		
		//get components (of type monobehavior)
		Profile p = Introspect ();
		
		//serialize profile class and export result
		bf.Serialize (file, p);
		file.Close ();
	}
	
	public void loadProfile( string filename ){
		
		Profile p;
		
		//find serialized profile on default datapath
		if (File.Exists (Application.persistentDataPath + "/" + filename + ".dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/" + filename + ".dat", FileMode.Open);
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
//using UnityEngine;
//using System.Collections;
//
////MenuItem("Test/FindAssetsUsingSearchFilter")
//	static void FindAssetsUsingSearchFilter ()
//{
//	// Find all assets labelled with 'concrete' : 
//	var guids = AssetDatabase.FindAssets ("l:concrete", null);
//	for (var guid in guids)
//		Debug.Log (AssetDatabase.GUIDToAssetPath(guid));
//	
//	// Find all Texture2Ds that have 'co' in their filename, that are labelled with 'concrete' or 'architecture' and are placed in 'MyAwesomeProps' folder
//	var guids2 = AssetDatabase.FindAssets ("co l:concrete l:architecture t:texture2D", ["Assets/MyAwesomeProps"]);
//	for (var guid in guids2)
//		Debug.Log (AssetDatabase.GUIDToAssetPath(guid));
//}
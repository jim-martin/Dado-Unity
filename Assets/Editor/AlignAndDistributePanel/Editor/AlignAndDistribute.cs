/*
// 	Author: DC Turner  
//	www.dcturner/net
// 	
//	Send question or comments to: mrdcturner@gmail.com
// 	Twitter:  @DcTurner
*/

using UnityEngine;
using UnityEditor;
public class AlignAndDistribute : EditorWindow {
	
	bool buttonsActive = false;
	static GUISkin alignSkin, distributeSkin;
	static string textureRoot = "AlignAndDistributeTextures/";
	
    [MenuItem ("Window/Align+Distribute")]
    static void Init () {
        EditorWindow lp =  EditorWindow.GetWindow (typeof (AlignAndDistribute));
		lp.maxSize = lp.minSize = new Vector2(100,210);
		lp.title = "align+Dist";
    }
	
	void OnSelectionChange()
	{
		// Are more than one game objects selected? If so, activate buttons.
		buttonsActive = Selection.transforms.Length>1;
		Repaint();
	}
	
    void OnGUI () 
	{	
		// skins used for the two button types
		alignSkin = (GUISkin)Resources.Load("AlignAndDistribute_alignButton");
		distributeSkin = (GUISkin)Resources.Load("AlignAndDistribute_distributeButton");
		
		// draw align buttons
		GUI.skin = alignSkin;
		drawButtons_align();
		
		// draw distribute buttons
		GUI.skin = distributeSkin;
		drawButtons_distribute();
    }

	void drawButtons_align ()
	{
		GUILayout.BeginVertical();

			// draw x button row
			GUILayout.BeginHorizontal();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("x_low")), 	"Align X Left")))	AlignAndDistribute_Logic.align_lowestX();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("x_middle")), 	"Align X Center")))	AlignAndDistribute_Logic.align_middleX();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("x_high")), 	"Align X Right")))	AlignAndDistribute_Logic.align_highestX();
			GUILayout.EndHorizontal();
		
			// draw y button row
			GUILayout.BeginHorizontal();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("y_low")), 	"Align Y Bottom")))	AlignAndDistribute_Logic.align_lowestY();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("y_middle")), 	"Align Y Center")))	AlignAndDistribute_Logic.align_middleY();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("y_high")), 	"Align Y Top")))	AlignAndDistribute_Logic.align_highestY();
			GUILayout.EndHorizontal();
		
			// draw z button row
			GUILayout.BeginHorizontal();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("z_low")), 	"Align Z Front")))	AlignAndDistribute_Logic.align_lowestZ();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("z_middle")), 	"Align Z Center")))	AlignAndDistribute_Logic.align_middleZ();
				if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("z_high")), 	"Align Z Back")))	AlignAndDistribute_Logic.align_highestZ();
			GUILayout.EndHorizontal();

		GUILayout.EndVertical();
	}
	void drawButtons_distribute ()
	{
		// draw distribution buttons
		GUILayout.BeginVertical();
			if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("DistributeX")), 	"Distribute X Axis")))	AlignAndDistribute_Logic.distributeHorizontal();
			if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("DistributeY")), 	"Distribute Y Axis")))	AlignAndDistribute_Logic.distributeVertical();
			if(GUILayout.Button(new GUIContent("", (Texture2D)Resources.Load(textureRoot+ texName("DistributeZ")), 	"Distribute Z Axis")))	AlignAndDistribute_Logic.distributeDepth();
		GUILayout.EndVertical();
	}
	
	/// Pass in a texture name. If the buttons are disabled, it will append '_disabled', allowing you to dynamically load enabled / disabled button textures
	string texName(string s)
	{
		return (buttonsActive) ? s : s+"_disabled";
	}

}
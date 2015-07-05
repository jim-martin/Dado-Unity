@script ExecuteInEditMode


import System.Collections.Generic;


var FireDot : Transform;
private var count : int = 0;
private var warning = false;
private var TString : String = "2";
private var createRatio : int = 0;
private var looper : int = 1;

private var containingTag : String = "";

function Create(){
	
	Debug.Log("Creating points for " + gameObject.name + " and all children...");

	var targets : List.<GameObject> = GetBurnableChildren( gameObject );	
	if(targets.Count < 1)
	{
		Debug.Log("No Burnable Objects Found");
	}
	
	
	for(var i: int = 0; i < targets.Count; i++){
		//Debug.Log(targets[i].name);
		MakePoints(targets[i]);
	}

}

function GetBurnableChildren( go : GameObject ) : List.<GameObject>
{
	//list to be returned
	var burnableChildren : List.<GameObject> = new List.<GameObject>();
	
	//get all children of the selected object
	var children = go.GetComponentsInChildren(Transform);	
	
	//check that they meet the criteria for burnable and commit them to the return list
	for( var child : Transform in children ){
		go = child.gameObject;
		if(go.GetComponent(MeshFilter) != null 
		&& go.name.Contains(containingTag)){
			burnableChildren.Add(go);
		}
	}
	
	return burnableChildren;
}

function MakePoints( go : GameObject )
{
	if (go.GetComponent(MeshFilter))
		{
			if (!go.transform.Find("FirePoints"))
				{
					count = 0;
					var myMesh : Mesh = go.GetComponent(MeshFilter).sharedMesh;
					if (myMesh.vertexCount <= 2000 || warning)
						{
							if (int.TryParse(TString, createRatio))
								{
									var subC : GameObject = new GameObject("FirePoints");
									subC.transform.parent = go.transform;
									subC.transform.position = go.transform.position;
									for (var vert : Vector3 in myMesh.vertices)
										{
											if (looper == 1)
												{
													var dot : Transform = Instantiate(FireDot, go.transform.TransformPoint(vert), Quaternion.identity);
													dot.name = "FirePoint"+count;
													dot.parent = subC.transform;
													count++;
												}
											if (looper >= createRatio)
												looper = 0;
											looper++;
										}
									Debug.Log(count+" Fire Points created.");
									warning = false;
								}
							else
								Debug.LogError("createRatio is not of type int.");
						}
					else
						{
							Debug.LogWarning("Vertices of the mesh exceeds 2000 ("+myMesh.vertexCount+"). It is recommended that you set the Create Ratio greater than 5.");
							warning = true;
						}
				}
			else
				Debug.LogError("Fire Points already created.");
		}
	else
		Debug.LogError("No mesh present for the object.");
}

function DestroyP()
{
	Debug.Log("Destroying points for " + gameObject.name + " and all children.");

	var targets : List.<GameObject> = GetBurnableChildren( gameObject );	
	
	for(var i: int = 0; i < targets.Count; i++){
		//Debug.Log(targets[i].name);
		DestroyPoints(targets[i]);
	}
}

function DestroyPoints( go : GameObject )
{
	if (go.transform.Find("FirePoints"))
		{
			DestroyImmediate(go.transform.Find("FirePoints").gameObject);
			Debug.Log("Fire Points destroyed.");
		}
}
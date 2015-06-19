Hi, Thank you for using my Dynamic Mesh System.

When you add the Dynamic Mesh as a component to your mesh inside the editor from "Component/Dynamic Mesh System/Dynamic Mesh"
you will be able to build the vertices of the mesh into empty gameobjects that you can move inside the editor and then click "Update Mesh"
to modify the mesh or you can move it in real time inside the game and use "UpdateMesh()".

Important:- When you modify the mesh in the editor it will be permanent to prevent mesh leaking.
To restore a mesh you have modified to its original state Click "Reset".
To remove the empty GameObjects click "Clear".

Dynamic Mesh System builds the empty gameobjects very carefully, it stores a list called "Singles" it is the list of the unique vertices,
when there is 2 or more vertices with the same position it stores the repetitions as a parent of a "Single" this is why when you build you will see that
some objects will have children (to prevent duplicate vertices used in triangles).

Functions :-

DynamicMesh.Build(bool StoreBackUp) :- Builds the mesh and sees if you want to store a backup in the memory or not, a back up will allow you to use ResetMesh()

DynamicMesh.UpdateMesh() :- Updates the mesh , call this whenever you want to apply the changes you have made.

DynamicMesh.ResetMesh() :- Restores the mesh from a backup, Do not call unless you have a backup.

Variables :-

int SinglesCount :- ammount of unique vertices ( the children , not the children of the children)

List<GameObject>Singles :- the list of the unique vertices used to modify vertices position.

GameObject[] VertsGO :- Array of all gameobjects of vertices including repetitions.

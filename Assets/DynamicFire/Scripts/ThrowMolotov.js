var Molotov : Transform;

function Update () 
{
	if (Input.GetMouseButtonUp(0))
		{
			var mol = Instantiate(Molotov, transform.position, Quaternion.identity);
			mol.GetComponent.<Rigidbody>().AddForce(600 * transform.forward);
			Physics.IgnoreCollision(transform.root.GetComponent.<Collider>(), mol.GetComponent.<Collider>());
		}
}
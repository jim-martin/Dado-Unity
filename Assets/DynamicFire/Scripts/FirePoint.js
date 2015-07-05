var fireParticle : Transform;
var firePoints : Transform[]; //Fire particles will be created at these positions once alight.
var fuel : float = 100.0; //The amount of fuel stored in this object. Fuel will burn out over time.
var fuelConsumption : float = 30.0; //The amount of fuel consumed per second by the object.
var fireSpread : float = 2.0; //The radius at which fire will spread
var spreadTime : float = 6.0; //The time after which fire will spread
var randomRange : float = 1.2; //The random maximum time after the spreadTime
var fallOutC : float = .05; //The chance that a Fire Point will fall out after some burn time
private var fireStarted : boolean = false;
private var fireC : Transform[];
private var count : int = 0;
private var fTime : short = 0.0;
private var fSpread : boolean = false;
private var fellOut : boolean = false;
private var bColor : boolean = false;
private var spPos : Vector3 = Vector3.zero;

function Update () 
{
	if (fireStarted)
		{
			fuel -= fuelConsumption * Time.deltaTime;
			if ((Time.time - fTime) >= spreadTime && !fSpread)
				{
					spreadFire();
					if (Random.value > .95 && transform.root && transform.root.GetComponent.<Renderer>() && !bColor)
						bColor = true;
				}
			if (!fellOut)
				{
					if (Random.value > 1-fallOutC)
						fallOut();
					fellOut = true;
				}
		}
	if (fuel <= 0 && fireStarted)
		endFire();
	if (bColor)
		{
			var CL : Color = transform.root.GetComponent.<Renderer>().material.color;
			CL.r -= .01 * Time.deltaTime;
			if (CL.r < .1)
				{
					CL.r = .1;
					bColor = false;
				}
			CL.g = CL.r;
			CL.b = CL.r;
			transform.root.GetComponent.<Renderer>().material.color = CL;
		}
}

function startFire()
{
	if (!fireStarted)
		{
			fireStarted = true;
			for (var all : Transform in firePoints)
				{
					var fire = Instantiate(fireParticle, all.position, Quaternion.identity);
					fire.parent = transform;
					fireC[count] = fire;
					count++;
				}
			fTime = Time.time;
		}
}

function endFire()
{
	for (var all2 : Transform in fireC)
		{
			if (all2.GetComponent.<ParticleEmitter>())
				all2.GetComponent.<ParticleEmitter>().emit = false;
			for (var child : Transform in all2)
				if (child.GetComponent.<ParticleEmitter>())
					child.GetComponent.<ParticleEmitter>().emit = false;
		}
	fireStarted = false;
	for (var all3 : Transform in firePoints)
		Destroy(all3.gameObject, 5);
	Destroy(this);
}

function Awake()
{
	fireC = new Transform[firePoints.length];
	setWind();
}

function spreadFire()
{
	fSpread = true;
	var InRange = Physics.OverlapSphere(spPos, fireSpread);
		for (var all : Collider in InRange)
			{
				yield WaitForSeconds(Random.value * randomRange);
				if (all.GetComponent("FirePoint"))
					all.SendMessage("startFire");
			}
}

function fallOut()
{
	transform.parent = null;
	GetComponent.<Rigidbody>().useGravity = true;
}

function setWind()
{
	yield WaitForSeconds(.1);
	switch (WindControl.windV)
		{
			case 0 : spPos = transform.position; break;
			case 1 : spPos = transform.position + Vector3(0, 0, fireSpread-(fireSpread/(1+(2 * (WindControl.windS+0.001))))); break;
			case 2 : spPos = transform.position - Vector3(fireSpread-(fireSpread/(1+(2 * (WindControl.windS+0.001)))), 0, 0); break;
			case 3 : spPos = transform.position + Vector3(fireSpread-(fireSpread/(1+(2 * (WindControl.windS+0.001)))), 0, 0); break;
			case 4 : spPos = transform.position - Vector3(0, 0, fireSpread-(fireSpread/(1+(2 * (WindControl.windS+0.001))))); break;
		}
}
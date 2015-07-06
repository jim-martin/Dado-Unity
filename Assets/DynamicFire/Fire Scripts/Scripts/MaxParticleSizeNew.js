var maxSize : float = 20;
function Update () {
	var particles = GetComponent.<ParticleEmitter>().particles;
	for(i = 0; i < GetComponent.<ParticleEmitter>().particleCount; i ++){
		if(particles[i].size > maxSize){
			particles[i].size = maxSize;
		}
	}
	GetComponent.<ParticleEmitter>().particles = particles;
}
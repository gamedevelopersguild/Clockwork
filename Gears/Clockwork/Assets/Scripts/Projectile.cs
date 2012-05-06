using UnityEngine;
using System.Collections;

public abstract class Projectile : MonoBehaviour 
{
	public GameObject explosion ;
	
	private const float TIMER = 10f;
	
	public float dmg ;
	
	void Start ()
	{
		Destroy(gameObject, TIMER) ;
	}
	
	protected abstract void setProjectile();
	
		
	protected void setDmg(float dmg) // Sets the dmg for a particular projectile. 
	{
		this.dmg = dmg ;
	}
	
	void OnTriggerEnter(Collider current)
	{	
		explode() ;
		
		if (current.tag == "Respawn")
			current.SendMessage("takeDamage", 25f);
		
		Destroy(gameObject) ;
	}
	
	void OnCollisionEnter(Collision current)
	{
		//explode() ;
	}
		
	private void explode()
	{
		Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation) ;
	}
	
	protected void move()
	{
		gameObject.transform.position += Vector3.right * 10f * Time.deltaTime;
		gameObject.transform.position += Vector3.down * 2f * Time.deltaTime;
	}
}

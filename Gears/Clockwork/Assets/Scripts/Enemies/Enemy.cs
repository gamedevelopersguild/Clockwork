using UnityEngine;
using System.Collections;

public abstract class Enemy : MonoBehaviour {
	protected EnemyAI AI;
	protected int gearsDropped;
	
	public float los;
	public int speed;
	public int health;
	
	public GameObject explosion ;
	
	public CharacterController characterController;
	
	public void SetAI(EnemyAI newAI)
	{
		AI = newAI;
	}
	
	public virtual void takeDamage(int dmg)
	{
		this.health -= dmg;
		
		if (health <= 0)
		{
			explode() ;
			Destroy(gameObject);
		}
	}
	
	public virtual void explode()
	{
		Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation) ;	
	}
}

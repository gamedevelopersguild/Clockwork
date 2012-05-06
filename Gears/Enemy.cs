using UnityEngine;
using System.Collections;

public abstract class Enemy : MonoBehaviour {
	protected EnemyAI AI;
	protected int gearsDropped;
	
	public float los;
	public int speed;
	public int health;
	
	public CharacterController characterController;
	
	public void SetAI(EnemyAI newAI) {
		AI = newAI;
	}
	
	public virtual void TakeDamage(int dmg) {
		this.health -= dmg;
	}
}

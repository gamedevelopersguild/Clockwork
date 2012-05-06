using UnityEngine;
using System.Collections;

public abstract class EnemyAI {
	public GameObject player;
	public bool isSpotted = false;
	
	public virtual void Control(Enemy enemy) {
		if(isPlayerSpotted(enemy)) PlayerInLOS(enemy); else PlayerOutOfLOS(enemy);
	}
	
	public virtual bool isPlayerSpotted(Enemy enemy) {
		if(!player) player = GameObject.FindGameObjectWithTag("Player");

		if(Vector3.Distance(player.transform.position, enemy.transform.position) <= enemy.los) {		
			if(!isSpotted) {
				isSpotted = true;
				PlayerSpotted(enemy);
			}
			return true;
		}
		
		if(isSpotted) {
			isSpotted = false;
			PlayerLost(enemy);
		}
		
		return false;
	}
	
	public virtual void PlayerSpotted(Enemy enemy) {
		return;	
	}
	
	public virtual void PlayerLost(Enemy enemy) {
		return;
	}
	
	public virtual void PlayerInLOS(Enemy enemy) {
		return;	
	}
		
	public virtual void PlayerOutOfLOS(Enemy enemy) {
		return;	
	}
}

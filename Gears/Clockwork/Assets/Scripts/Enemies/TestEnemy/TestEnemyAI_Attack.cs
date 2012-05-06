using UnityEngine;
using System.Collections;

public class TestEnemyAI_Attack : EnemyAI {
	
	public override void Control (Enemy enemy)
	{
		base.Control (enemy);
	}
	
	
	//This function will be called once, when the player
	//has left the LOS.
	public override void PlayerLost (Enemy enemy)
	{
		enemy.SetAI(new TestEnemyAI_Idle());
	}
	
	//This function will be called every frame the player
	//is in los.
	public override void PlayerInLOS (Enemy enemy)
	{
		Approach(enemy);
	}
	
	
	private void Approach(Enemy enemy) {
		Vector3 direction = enemy.transform.position.x - player.transform.position.x > 0 ? Vector3.left : Vector3.right;
		direction *= (enemy.speed * Time.deltaTime);
		enemy.characterController.SimpleMove(direction);
	}
		
}

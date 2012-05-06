using UnityEngine;
using System.Collections;

public class HammerHeadAI_Attack : EnemyAI
{
	bool amIGonnaBlowUpYet = false;
	
	public Enemy curEnemy;
	public override void Control (Enemy enemy)
	{
		base.Control (enemy);
		if(amIGonnaBlowUpYet) 
		{
			Debug.Log(enemy.animation["Attack"].time);
			if(enemy.animation["Attack"].time >= 1) 
			{
				enemy.explode();
				amIGonnaBlowUpYet = false;
			}	
		}
		
	}	
	
	public override void PlayerSpotted (Enemy enemy)
	{
		amIGonnaBlowUpYet = true;
		curEnemy = enemy;
		enemy.animation.Play("Attack");
		
	}
	
}

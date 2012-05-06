using UnityEngine;
using System.Collections;

public class AttackBotAI_Idle : EnemyAI 
{
	public override void Control (Enemy enemy)
	{
		base.Control(enemy);
	}

	public override void PlayerSpotted (Enemy enemy)
	{
		enemy.SetAI(new AttackBotAI_Attack());
	}
}

using UnityEngine;
using System.Collections;

public class RobotWhompAI_Idle : EnemyAI
{
	
public override void Control (Enemy enemy)
	{
		base.Control(enemy);
	}

	public override void PlayerSpotted (Enemy enemy)
	{
		enemy.SetAI(new TestEnemyAI_Attack());
	}
}
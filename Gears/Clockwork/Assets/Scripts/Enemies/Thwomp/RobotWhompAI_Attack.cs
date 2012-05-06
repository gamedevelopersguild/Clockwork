using UnityEngine;
using System.Collections;

public class RobotWhompAI_Attack : EnemyAI
{
	
public override void Control (Enemy enemy)
	{
		base.Control (enemy);
	}
	
	
	//This function will be called once, when the player
	//has left the LOS.
	public override void PlayerLost (Enemy enemy)
	{
		enemy.SetAI(new RobotWhompAI_Idle());
	}
	
	//This function will be called every frame the player
	//is in los.
}
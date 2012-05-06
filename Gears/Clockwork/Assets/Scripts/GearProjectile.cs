using UnityEngine;
using System.Collections;

public class GearProjectile : Projectile
{
	protected override void setProjectile()
	{
		dmg = 20f;
	}
	
	void Update()
	{
		move();
	}
}

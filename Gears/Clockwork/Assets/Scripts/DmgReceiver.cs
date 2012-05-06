using UnityEngine;
using System.Collections;

public class DmgReceiver : MonoBehaviour 
{
	Player obj ;
	
	public void dmgReceiver(float dmg)
	{
		obj.takeDamage(dmg);
	}
}

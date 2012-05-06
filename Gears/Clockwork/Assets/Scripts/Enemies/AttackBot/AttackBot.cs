using UnityEngine;
using System.Collections;

public class AttackBot : Enemy
{
	void Start () 
	{
		this.SetAI(new AttackBotAI_Idle());
	//	health = 25;
	}

	void Update ()
	{
		AI.Control(this);
	}
		
	void OnTriggerEnter(Collider current)
	{			
		if (current.tag == "Player") 
		{			
			current.SendMessage("takeDamage", 20f);
			takeDamage(100) ; // kill self.
		}
	}
}


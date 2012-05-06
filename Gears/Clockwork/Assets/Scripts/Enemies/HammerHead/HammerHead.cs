using UnityEngine;
using System.Collections;

public class HammerHead : Enemy
{
	public GameObject explosionSpawnPointOfDoomAndGloomAHAHAHAHAAAAA;
	void Start () 
	{
		this.SetAI(new HammerHeadAI_Attack());
	}

	void Update ()
	{
		AI.Control(this);
	}
	
	public override void explode ()
	{
		Instantiate(explosion,explosionSpawnPointOfDoomAndGloomAHAHAHAHAAAAA.transform.position, explosionSpawnPointOfDoomAndGloomAHAHAHAHAAAAA.transform.rotation) ;
		Destroy(gameObject);
	}
	
	void OnTriggerEnter(Collider current)
	{
		Debug.Log("Im here" + current.tag) ;
		
		if (current.tag == "Player")
		{
			Debug.Log("Im here2 " + current.tag) ;
			
			explode() ;
		}
		
	}
		
}


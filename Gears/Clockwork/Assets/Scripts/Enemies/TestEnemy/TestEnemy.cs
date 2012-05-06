using UnityEngine;
using System.Collections;

public class TestEnemy : Enemy {

	// Use this for initialization
	void Start () {
		this.SetAI(new TestEnemyAI_Idle());
	}
	
	// Update is called once per frame
	void Update () {
		AI.Control(this);
	}
	
}

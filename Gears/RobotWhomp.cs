using UnityEngine;
using System.Collections;

public class RobotWhomp : Enemy 
{
	
	// Use this for initialization
	void Start () {
		this.SetAI(new RobotWhompAI_Idle());
	}
	
	// Update is called once per frame
	void Update () {
			int minPos = 0;
			int maxPos = 1;
			
			if(minPos == maxPos)
			{
			minPos ++;
			Vector3 newPos = new Vector3(gameObject.transform.position.x,
										 gameObject.transform.position.y - 1 * Time.deltaTime,
										 gameObject.transform.position.z);
			
			gameObject.transform.position = newPos;
			}
			else
				{
			Vector3 newPos = new Vector3(gameObject.transform.position.x,
										 gameObject.transform.position.y + 2 * Time.deltaTime,
										 gameObject.transform.position.z);
				}
			
			
		
		AI.Control(this);
	}
}

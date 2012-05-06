using UnityEngine;
using System.Collections;

public class GearSpinner : MonoBehaviour 
{
	public float speedX = 0f;
	public float speedY = 0.5f;
	public float speedZ = 0f;
	
	void Update () 
	{
		gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x + speedX, 
													   gameObject.transform.eulerAngles.y + speedY, 
			                                           gameObject.transform.eulerAngles.z + speedZ);
	}
}

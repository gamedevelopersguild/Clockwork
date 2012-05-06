using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour 
{
	public float speed = 0.5f;
	
	void Update () 
	{
		gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x,
													   gameObject.transform.eulerAngles.y,
													   gameObject.transform.eulerAngles.z + speed);
	}
}

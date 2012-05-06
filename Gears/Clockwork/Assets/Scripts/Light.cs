using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {
	
//	bool down;
	// Use this for initialization
	void Start () 
	{
			//light.intensity = 1.8f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		light.intensity += 0.05f ;
		
		if (light.intensity >=3f)
			light.intensity = 1.6f;
	}
}

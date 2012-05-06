using UnityEngine;
using System.Collections;

public class YouWin : MonoBehaviour {
	
	
	public string sceneToLoad;
	

	
	void OnTriggerEnter	(Collider current)
	{
		if (current.tag == "Player" )
		{
			
			//wait 
			// then do this.
			Application.LoadLevel(sceneToLoad);
		}
	}
}

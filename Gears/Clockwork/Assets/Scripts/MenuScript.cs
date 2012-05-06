using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour 
{
	public string sceneToLoad;
	public bool isExitButton = false;
	
	public AudioClip hoverSound, 
					 clickSound ;
	
	void OnMouseEnter() // Ontop of button.
	{
		
	}
	
	void OnMouseUp()
	{
		audio.PlayOneShot(clickSound);
		
		
		if(isExitButton)
		{
			Application.Quit();
		}
	
		else
		{
			Application.LoadLevel(sceneToLoad);
		}
	}
}

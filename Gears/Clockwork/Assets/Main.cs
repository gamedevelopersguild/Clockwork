using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public int numOfGears;
	public GUIController gui_Controller;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("SubtractGears", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p")) gui_Controller.OpenMenu();
		if(Input.GetKeyDown("c"))gui_Controller.CloseMenu();
		if (numOfGears <= 0)
		{
			Application.LoadLevel("Menu");
		}
	}
	
	void SubtractGears() {
		if(numOfGears > 0) {
			numOfGears--;
		} else Die();
	}
	
	public void substractStuff(int amount)
	{
		numOfGears -= amount;
	}
	
	void Die() 
	{
		Debug.Log("AHH");
		gui_Controller.OpenMenu();
		//Communicate to the player object that it should be dead. 	
	}
}

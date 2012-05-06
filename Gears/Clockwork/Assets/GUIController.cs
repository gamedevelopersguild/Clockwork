using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUIController : MonoBehaviour {
	
	//HUD Images
	public Texture2D ore;
	public Texture2D energy;
	
	//Skin to be applied to UI
	public GUISkin gui_skin;
	
	//Menu Items
	string desc = "";
	string moduleName = "";
	
	public List<MenuItem> menuItems = null;
	
	public Main main;
	
	//Menu's Current Position
	float menu_x;
	
	//Menu's Target Position
	float menu_x_target;
	
	//The speed at which the menu opens and closes
	public float menuSpeed;
	
	public GUI_State state;
	
	// Use this for initialization
	void Awake () {
		menu_x = Screen.width;
		menu_x_target = Screen.width;
		
		menuItems = new List<MenuItem>();
		menuItems.Add(new MenuItem("Resume"));
		menuItems.Add(new MenuItem("Exit"));
		
		state = new TopDownGUI();
	}
	
	void OnGUI() {
		state.Control(this);
		HandleMenu();
	}
		
	public void HandleMenu() {
		#region Menu Handler
		Rect menuRect = CalculateMenuRect();
		
		//Added + .5 as a buffer, since menu never seems
		//to go all the way back to Screen.width position
		if(menuRect.x + .5 < Screen.width) {
			MenuItem selected = GUI_Elements.Menu(menuRect, moduleName, desc, menuItems);
			if(selected != null) {
				//controller.MenuItemSelected(selected);	
			}
		}
		#endregion
	}
	
	public void OpenMenu() {
		menu_x_target = Screen.width/2;
		this.moduleName = "Pause Menu";
		this.desc = "This is the Pause Menu";
	}
	
	public void OpenMenu(string name, string desc, List<MenuItem> items) {
		menu_x_target = Screen.width/2;
		menuItems = items;
		this.desc = desc;
		this.moduleName = name;
	}	
	
	public void CloseMenu() 
	{
		menu_x_target = Screen.width;
		//menuItems = null;
		//desc = "";
	}
	
	Rect CalculateMenuRect() 
	{
		Rect menuRect = new Rect(Mathf.Lerp(menu_x, menu_x_target, menuSpeed),
             0,
             Screen.width/2,
             Screen.height);
		
		menu_x = menuRect.x;
		return menuRect;
	
	}
}

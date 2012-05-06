using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUI_Elements {
	static int menuItemPadding = 30;
	
	static int titleBottomPadding = 50;
	static int descBottomPadding = 150;
	
	static int menuItemHeight = 20;
	static int menuItemWidth = 150;
	
	//These are the resource displays at the top
	//of the screen
	public static void HUDElements (Rect screenRect, Texture2D picture, int amt) {
		GUI.DrawTexture(screenRect, picture);
		screenRect.x += screenRect.width; 	
		screenRect.y = screenRect.height/4;
		GUI.Label(screenRect, "" + amt);
	}
	
	public static MenuItem Menu(Rect menuRect, string moduleName, string desc, List<MenuItem> items) {		        
		GUI.Box(menuRect, moduleName);
		menuRect.y += titleBottomPadding;
		GUI.Label(menuRect, desc);
		
		menuRect.y += descBottomPadding;
		menuRect.height = menuItemHeight;
		menuRect.width = menuItemWidth; 
		
		if(items != null) {
			foreach(MenuItem item in items) {
				menuRect.y += menuItemPadding;
				if(GUI.Button(menuRect, item.text)) return item;
			}
		}
		
		return null;
		
	}
}

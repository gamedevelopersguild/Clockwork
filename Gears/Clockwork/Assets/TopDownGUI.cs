using UnityEngine;
using System.Collections;

public class TopDownGUI : GUI_State {
	public void Control (GUIController gui)
	{
		#region Standard GUI
		GUI.skin = gui.gui_skin;
		GUI_Elements.HUDElements(new Rect(0, 0, 75, 50), gui.ore, gui.main.numOfGears);
		#endregion
	}
}

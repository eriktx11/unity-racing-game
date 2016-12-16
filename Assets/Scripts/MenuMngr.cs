using UnityEngine;
using System.Collections;

public class MenuMngr : MonoBehaviour {

	public Menu currentMenu;

	public void Start(){
	
		ShowMenu (currentMenu);
	}

	public void ShowMenu(Menu menu){

		if (currentMenu != null) {
			currentMenu = menu;

			if (currentMenu.isOpen == true) {
				currentMenu.isOpen = false;
			} else {
				currentMenu.isOpen = true;
			}

		} 
	}

}

using UnityEngine;
using System.Collections;

public class MenuMngr : MonoBehaviour {

	public Menu currentMenu;

	public void Start(){
	
		ShowMenu (currentMenu);
	}

	public void ShowMenu(Menu menu){

		if(currentMenu!=null){
			currentMenu.isOpen = false;

			currentMenu = menu;
			currentMenu.isOpen = false;
		}
	}

}

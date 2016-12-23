using UnityEngine;
using System.Collections;


public class MenuMngr : MonoBehaviour {

	public Menu currentMenu;
	private GameObject isRunning;
	private GameObject isWrongWayCar;


	public void Start(){
	
		isRunning = GameObject.FindGameObjectWithTag("Spawner");
		isWrongWayCar = GameObject.FindGameObjectWithTag("police-car-one");
		ShowMenu (currentMenu);
	}


	public void ShowMenu(Menu menu){

		if (currentMenu != null) {
			currentMenu = menu;

			if (currentMenu.isOpen == true) {
				currentMenu.isOpen = false;
				isRunning.SetActive(false);
				isWrongWayCar.SetActive(false);

			} else {
				currentMenu.isOpen = true;
				isRunning.SetActive(true);
				isWrongWayCar.SetActive(true);
			}


		} 
	}

}

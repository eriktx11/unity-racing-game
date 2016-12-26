using UnityEngine;
using System.Collections;


public class MenuMngr : MonoBehaviour {

	public Menu currentMenu;
	private GameObject isRunning;
	private GameObject isWrongWayCar;

	private GameObject audioObj;
	private AudioSource audioSrc;

	public void Start(){
	
		isRunning = GameObject.FindGameObjectWithTag("Spawner");
		isWrongWayCar = GameObject.FindGameObjectWithTag("carGroupTag");
		ShowMenu (currentMenu);
	}


	public void ShowMenu(Menu menu){

		if (currentMenu != null) {
			currentMenu = menu;

			if (currentMenu.isOpen == true) {
				currentMenu.isOpen = false;
				isRunning.SetActive(false);
				isWrongWayCar.SetActive(false);

				audioObj = GameObject.FindGameObjectWithTag("chiefAuTag");
				audioSrc = audioObj.GetComponent<AudioSource>();
				audioSrc.enabled = false;

				audioObj = GameObject.FindGameObjectWithTag ("policeAuTag");
				audioSrc = audioObj.GetComponent<AudioSource> ();
				audioSrc.enabled = false;

				audioObj = GameObject.FindGameObjectWithTag ("policeRemixAuTag");
				audioSrc = audioObj.GetComponent<AudioSource> ();
				audioSrc.enabled = false;

				audioObj = GameObject.FindGameObjectWithTag("roosterAuTag");
				audioSrc = audioObj.GetComponent<AudioSource>();
				audioSrc.enabled = false;

			} else {
				currentMenu.isOpen = true;
				isRunning.SetActive(true);
			}


		} 
	}

}

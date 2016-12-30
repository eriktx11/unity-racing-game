using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuMngr : MonoBehaviour {

	public Menu currentMenu;
//	public MenuButton crossButton;

//
//	private Animator _animator;
//	private CanvasGroup _canvasGroup;

	public Sprite myImage;
	public Button myBtn;
	public Sprite newImage;

	private Sprite swapSprite;

	private GameObject isRunning;
	private GameObject isWrongWayCar;

	private GameObject audioObj;
	private AudioSource audioSrc;

//	public bool isOpen
//	{
//		get{return _animator.GetBool ("isOpen");}
//		set{_animator.SetBool ("isOpen", value);}
//	}

//	public void Awake(){
//		_animator = GetComponent<Animator> ();
//		_canvasGroup = GetComponent<CanvasGroup>();
//	}

	public void Start(){
	
		isRunning = GameObject.FindGameObjectWithTag("Spawner");
		isWrongWayCar = GameObject.FindGameObjectWithTag("carGroupTag");
		ShowMenu (currentMenu);
//		CrossMenu (crossButton);
	}

//	public void Update () {
//
//		if(!_animator.GetCurrentAnimatorStateInfo(0).IsName("on")){
//			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
//		}else{
//			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;
//		}
//	}

//	public void CrossMenu(MenuButton menucross){
//	
//		if (crossButton != null) {
//			crossButton = menucross;
//			if (crossButton.isOpen == true) {
//				crossButton.isOpen = false;
//			} else {
//				crossButton.isOpen = true;
//			}
//		}
//	}

	public void ShowMenu(Menu menu){

		if (currentMenu != null) {
			currentMenu = menu;

			if (currentMenu.isOpen == true) {
				currentMenu.isOpen = false;
				//crossButton.isOpen = false;
				isRunning.SetActive(false);
				isWrongWayCar.SetActive(false);

				audioObj = GameObject.FindGameObjectWithTag("chiefAuTag");
				audioSrc = audioObj.GetComponent<AudioSource>();
				audioSrc.enabled = false;

				audioObj = GameObject.FindGameObjectWithTag("ballAuTag");
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

				swapSprite = GetComponent<SpriteRenderer>().sprite = newImage;
				//Make sure it is added in the Inspector. Or reference it using GameObject.Find.
				myBtn.image.sprite = swapSprite; // That is right, no need to GetComponent.

			} else {
				currentMenu.isOpen = true;
				isRunning.SetActive(true);
				//crossButton.isOpen = true;
				//myImage = Resources.Load<Sprite>("x"); // Make sure not to include the file extension

				swapSprite = GetComponent<SpriteRenderer>().sprite = myImage;
				//Make sure it is added in the Inspector. Or reference it using GameObject.Find.
				myBtn.image.sprite = swapSprite; // That is right, no need to GetComponent.
			}


		} 
	}

}

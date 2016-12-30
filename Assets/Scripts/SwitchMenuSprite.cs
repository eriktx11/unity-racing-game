using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwitchMenuSprite : MonoBehaviour {
	
	// Update is called once per frame
//	void Update () {
//	
//	}
	public Sprite myImage;
	public Sprite newImage;
	public Button myBtn;
	void Start(){

		myImage = Resources.Load<Sprite>("as"); // Make sure not to include the file extension

		//Make sure it is added in the Inspector. Or reference it using GameObject.Find.
		myBtn.image.sprite = myImage; // That is right, no need to GetComponent.

	}
}

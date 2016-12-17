using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spriteSwitch : MonoBehaviour {

	private List<GameObject> models;
	private int selectionIndex=0;
//	public Sprite animB;
//	public Sprite nowPlaying;


	//private RaycastHit2D hit2d;


	// Use this for initialization
	private void Start () {
//		this.gameObject.GetComponent<SpriteRenderer> ().sprite = nowPlaying;
		models = new List<GameObject>();
		foreach (Transform t in transform) {
			models.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}
		models [selectionIndex].SetActive (true);
	}
	
	// Update is called once per frame
	public void setNewCar (int x) {


		if (selectionIndex == x) {
			return;
		}

		if (x < 0 || x > models.Count) {
			return;
		}

		models [selectionIndex].SetActive (false);
		selectionIndex = x;
		models [selectionIndex].SetActive (true);




		//mainCharacter = GameObject.Find("police-car").GetComponent("police-car");

	//	if(Input.touchCount > 0){//(0).phase==TouchPhase.Began
			//hit2d = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position), Vector2.zero);
//			if (hit2d.collider != null && hit2d.transform.gameObject.tag == "police-car-one") {
//			gameObject.GetComponent<> = this.gameObject.GetComponent<Image> ();
//			}
//			if (hit2d.collider != null && hit2d.transform.gameObject.tag == "police-car-two") {
//				this.gameObject.GetComponent<SpriteRenderer> ().sprite = animB;
//			//}
		//}
	}
}

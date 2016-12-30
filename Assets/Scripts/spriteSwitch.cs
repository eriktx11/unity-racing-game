using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spriteSwitch : MonoBehaviour {

	private List<GameObject> models;
	private int selectionIndex=0;
	private GameObject isWrongWayCar;

	private GameObject audioObj;
	private AudioSource audioSrc;

	private void Awake(){
//		audioObj = GameObject.FindGameObjectWithTag("chiefAuTag");
//		audioSrc = audioObj.GetComponent<AudioSource>();
//		audioSrc.enabled = false;

	}

	private void Start () {

		models = new List<GameObject>();
		foreach (Transform t in transform) {
			models.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}
		models [selectionIndex].SetActive (true);
		isWrongWayCar = GameObject.FindGameObjectWithTag("carGroupTag");
	}
	
	// Update is called once per frame
	public void setNewCar (int x) {


//		if (selectionIndex == x) {
//			isWrongWayCar.SetActive(true);
//			return;
//		}

		if (x < 0 || x > models.Count) {
			return;
		}

		switch (x) {
		case 0: 
			audioObj = GameObject.FindGameObjectWithTag("chiefAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("ballAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("roosterAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("policeRemixAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag ("policeAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = true;
			audioSrc.Play ();
			break;
		case 1:
			audioObj = GameObject.FindGameObjectWithTag("chiefAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("ballAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("policeAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("roosterAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag ("policeRemixAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = true;
			audioSrc.Play ();
			break;


		case 2:	
			audioObj = GameObject.FindGameObjectWithTag ("policeAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("ballAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag ("policeRemixAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("roosterAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag ("chiefAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = true;
			audioSrc.Play ();
			break;

		case 4:
			audioObj = GameObject.FindGameObjectWithTag ("policeAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("ballAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag ("policeRemixAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("chiefAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("roosterAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = true;
			audioSrc.Play ();
			break;

		case 5:
			audioObj = GameObject.FindGameObjectWithTag ("policeAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("roosterAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag ("policeRemixAuTag");
			audioSrc = audioObj.GetComponent<AudioSource> ();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("chiefAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = false;

			audioObj = GameObject.FindGameObjectWithTag("ballAuTag");
			audioSrc = audioObj.GetComponent<AudioSource>();
			audioSrc.enabled = true;
			audioSrc.Play ();
			break;
			
		}


		models [selectionIndex].SetActive (false);
		selectionIndex = x;
		models [selectionIndex].SetActive (true);

		isWrongWayCar.SetActive(true);

	}
}

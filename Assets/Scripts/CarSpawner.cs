using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

	public GameObject[] cars;
	int carNo;
	public float maxPos = 4.17f;
	public float delayTimer = 0.5f;

	float timer;

	// Use this for initialization
	void Start () {
		#if UNITY_ANDROID || UNITY_IPHONE
		delayTimer = 0.5f;
		#endif
		timer = delayTimer;
	}

	public void disable(){
		
//		GameObject origin = GameObject.FindGameObjectWithTag ("Spawner");
//		origin.SetActive (false);


		}


	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0) {
			Vector3 carPos = new Vector3(Random.Range(-4.17f, 4.17f),transform.position.y,transform.position.z);
			carNo = Random.Range (0,5);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delayTimer;
		}
	}
}

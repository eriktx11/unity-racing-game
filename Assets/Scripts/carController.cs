using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider2D))]
public class carController : MonoBehaviour {

	public float carSpeed;
	public float maxPos = 4.17f;

	Vector3 position;

	public ParticleHit pr;
	public AudioManager cr;
	public Blast cb;


	bool currntPlatformAndroid = false;
//	Rigidbody2D rb;

	private Vector3 endPoint;
	private bool flag = false;
	public float duration = 1.0f;
	//vertical position of the gameobject
	private float yAxis;
	public uiManager ui;



	void Start(){
		//save the y axis value of gameobject
		yAxis = gameObject.transform.position.y;

	}



	void Awake(){
		#if UNITY_ANDROID || UNITY_IPHONE
				currntPlatformAndroid = true;
		#else
				currentPlatformAndroid = false;
		#endif

		cr.carSound.Play ();

	
	}

	void TouchMove(){

			if (Input.touchCount > 0 && 
				Input.GetTouch(0).phase == TouchPhase.Moved) {

			//declare a variable of RaycastHit struct
			RaycastHit hit;
			//Create a Ray on the tapped / clicked position
			Ray ray;
			//for unity editor
			#if UNITY_EDITOR
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//for touch device
			#elif (UNITY_ANDROID || UNITY_IPHONE || UNITY_WP8)
			ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			#endif

			//Check if the ray hits any collider
			if(Physics.Raycast(ray,out hit))
			{
				//set a flag to indicate to move the gameobject
				flag = true;
				//save the click / tap position
				endPoint = hit.point;
				//as we do not want to change the y axis value based on touch position, reset it to original y axis value
				endPoint.y = yAxis;
			}
				

		}
		//check if the flag for movement is true and the current gameobject position is not same as the clicked / tapped position
		if(flag && !Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude)){ //&& !(V3Equal(transform.position, endPoint))){
			//move the gameobject to the desired position
			gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1/(duration*(Vector3.Distance(gameObject.transform.position, endPoint))));
		}
		//set the movement indicator flag to false if the endPoint and current gameobject position are equal
		else if(flag && Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude)) {
			flag = false;
		}
	}
		
	

	void Update () {

		if (currntPlatformAndroid == true) {
			
			TouchMove();
		}

		else {

			position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
			position.x = Mathf.Clamp (position.x, -4.17f, 4.17f);

			transform.position = position;
		}

		position = transform.position;
		position.x = Mathf.Clamp (position.x, -4.17f, 4.17f);
		transform.position = position;

	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "EnemyCar") {

			gameObject.SetActive(false);

			ui.gameOverActivated();
			cr.carSound.Stop();
			cb.blast.Play ();
			pr.crashParticles.Play();
		}
	}
}
using UnityEngine;
using System.Collections;
using System.IO;

public class playerMovement : MonoBehaviour {
	const float playerSpeed = 20f;
	

	// Use this for initialization
	void Start () {
		//this.GetComponent<eventHandler>().enemeySpotted += enemeySpotted;
	
	}
	
	//void enemeySpotted(GameObject go) {
		
	//}
	
	// Update is called once per frame
	void Update () {		
		float horizontalSpeed = 10.0f;
		float verticalSpeed  = 10.0f;
	    float h = horizontalSpeed * Input.GetAxis("Mouse X");
		float v = verticalSpeed * Input.GetAxis ("Mouse Y");
		
		if (Input.GetMouseButton(1)) {
			transform.Rotate(0, h, 0);
		}
		
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.forward / playerSpeed, Space.Self);			
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(Vector3.back / playerSpeed, Space.Self);			
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Translate(Vector3.left / playerSpeed, Space.Self);			
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector3.right / playerSpeed, Space.Self);			
		}
		if (Input.GetKey(KeyCode.Space)) {
			transform.Translate(Vector3.up / playerSpeed, Space.World);
		}
	}	
	
	void OnCollisionEnter(Collision collision){
		if (collision.collider.tag == "Enemy") {
			if (Input.GetMouseButton(0)) {
				//collision.collider.gameObject.transform.Translate(10,10,10,Space.Self);
				collision.collider.transform.Translate(0,5,0,Space.World);
			}
		}
	}
	
	void OnCollisionStay(Collision collision){
		if (collision.collider.tag == "Enemy") {
			if (Input.GetMouseButton(0)) {
				//collision.collider.gameObject.transform.Translate(10,10,10,Space.Self);
				collision.collider.transform.Translate(0,5,0,Space.World);
			}
		}
	}
}

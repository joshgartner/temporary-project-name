using UnityEngine;
using System.Collections;
using System.IO;

public class playerMovement : MonoBehaviour {
	const float playerSpeed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {		
		float horizontalSpeed = 10.0f;
		float verticalSpeed  = 10.0f;
	    float h = horizontalSpeed * Input.GetAxis("Mouse X");
		float v = verticalSpeed * Input.GetAxis ("Mouse Y");
		transform.Rotate(0, h, 0);
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward / playerSpeed, Space.Self);			
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back / playerSpeed, Space.Self);			
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left / playerSpeed, Space.Self);			
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right / playerSpeed, Space.Self);			
		}
		//if (Input.GetMouseButton(0))
		//{
		//}
	}	
}

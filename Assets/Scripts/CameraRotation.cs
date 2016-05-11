using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
		transform.rotation = Quaternion.Euler(-mouseY, mouseX, 0) * transform.rotation;
	}
}

using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {
	public float speed = 5.0f;
	public GameObject ballPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			Rigidbody rb = CreateBall();
			Camera camera = GetComponentInChildren<Camera>();

			rb.velocity = camera.transform.rotation * Vector3.forward * speed;
		}
	}

	Rigidbody CreateBall () {
		GameObject instance = Instantiate(ballPrefab);
		Camera camera = GetComponentInChildren<Camera>();
		instance.transform.position = camera.transform.position;
		Rigidbody rb = instance.GetComponent<Rigidbody>();
		return rb;
	}
}

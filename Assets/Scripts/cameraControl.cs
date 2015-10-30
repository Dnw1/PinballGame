using UnityEngine;
using System.Collections;
//Dylan Waij

public class cameraControl : MonoBehaviour {
	//
	public Camera camera;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;

	void Start() {
		camera.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
	}
	void Update() {
		//This will toggle the cameras, it is not efficient but was made purely to be workable.
		if (Input.GetKeyDown (KeyCode.F1)) {
			camera.enabled = true;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = false;
		} 
		if (Input.GetKeyDown (KeyCode.F2)) {
			camera.enabled = false;
			camera2.enabled = true;
			camera3.enabled = false;
			camera4.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.F3)) {
			camera.enabled = false;
			camera2.enabled = false;
			camera3.enabled = true;
			camera4.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.F4)) {
			camera.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = true;
		}
	 }
}
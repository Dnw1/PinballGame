using UnityEngine;
using System.Collections;
//Dylan Waij

public class Flipper2 : MonoBehaviour 
{/*
	public float maxAngle = 20.0f;
	public float flipTime = 1.0f;
	public string buttonName;

	private Quaternion initialOrientation;
	private Quaternion finalOrientation;
	private float t;

	public float thrust;

	// Use this for initialization
	void Start () 
	{
		initialOrientation = transform.rotation;
		finalOrientation.eulerAngles = new Vector3 (initialOrientation.eulerAngles.x, initialOrientation.eulerAngles.y + maxAngle, initialOrientation.eulerAngles.z);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown(buttonName)) {
			transform.rotation = Quaternion.Slerp (initialOrientation, finalOrientation, t / flipTime);
			t += Time.deltaTime;
			if (t > flipTime) {
				t = flipTime;
			}
		} else 
		{
			transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t/flipTime);
			t -= Time.deltaTime;
			if(t < 0)
			{
				t = 0;
			}
		}
	}
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Ball") 
		{
			col.rigidbody.AddForce(Vector3.forward * thrust);
		}
	}*/
}

using UnityEngine;
using System.Collections;
//Dylan Waij

public class ReversibleGravity : MonoBehaviour {
	
	Vector3 gravity;
	// Use this for initialization
	void Start () {
		gravity = Physics.gravity;
	}

	void FixedUpdate()
	{
		Physics.gravity = gravity;

		gravity.x = 0f;
		gravity.y = -10.81f;
		gravity.z = -8f;
	}
}

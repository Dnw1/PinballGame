<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class ReversibleGravity : MonoBehaviour {
	
	Vector3 gravity;
	// Use this for initialization
	void Start () {
		gravity = Physics.gravity;
	}
	
	// Update is called once per frame
	void Update () {
		//
	}
	void FixedUpdate()
	{
		Physics.gravity = gravity;

		gravity.x = 0f;
		gravity.y = -10.81f;
		gravity.z = -8f;
	}
}
=======
﻿using UnityEngine;
using System.Collections;

public class ReversibleGravity : MonoBehaviour
{
	Vector3 gravity;
	// Use this for initialization
	void Start ()
    {
		gravity = Physics.gravity;
	}
	
	// Update is called once per frame
	void Update ()
    {
		//
	}
	void FixedUpdate()
	{
		Physics.gravity = gravity;

		gravity.x = 0f;
		gravity.y = -9.81f;
		gravity.z = -8f;
	}
}
>>>>>>> origin/master

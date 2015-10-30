<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Danny van der Zee

public class Launcher : MonoBehaviour
{
    public float force = 100.0f;
    public string buttonName = "Fire3";

    private List<Rigidbody> ballList = new List<Rigidbody>();
	
    // Use this for initialization
	void Start ()
    {
        //
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown(buttonName))
        {
            foreach (Rigidbody ball in ballList)
            {
                ball.AddForce(Vector3.forward * force,ForceMode.VelocityChange);
            }
        }
	}

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("object entred");
        if(col.GetComponent<Rigidbody>())
        {
            //Debug.Log("object has rigidbody");
            ballList.Add(col.GetComponent<Rigidbody>());
        }
    }

    void OnTriggerExit(Collider col)
    {
        //Debug.Log("object exited");
        if (col.GetComponent<Rigidbody>())
        {
            //Debug.Log("object has rigidbody");
            ballList.Remove(col.GetComponent<Rigidbody>());
        }
    }
}
=======
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private float force = 100.0f;
    private string buttonName = "Fire1";

    private List<Rigidbody> ballList = new List<Rigidbody>();
	
    // Use this for initialization
	void Start ()
    {
        //
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown(buttonName))
        {
            foreach (Rigidbody ball in ballList)
            {
                ball.AddForce(Vector3.forward * force,ForceMode.VelocityChange);
            }
        }
	}

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("object entred");
        if(col.GetComponent<Rigidbody>())
        {
            //Debug.Log("object has rigidbody");
            ballList.Add(col.GetComponent<Rigidbody>());
        }
    }

    void OnTriggerExit(Collider col)
    {
        //Debug.Log("object exited");
        if (col.GetComponent<Rigidbody>())
        {
            //Debug.Log("object has rigidbody");
            ballList.Remove(col.GetComponent<Rigidbody>());
        }
    }
}
>>>>>>> origin/master

using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class flipper : MonoBehaviour {
	
	private HingeJoint hinge;
	
	void Start() {
		hinge = this.GetComponent<HingeJoint>();
	}
	
	public void on() {
		hinge.useMotor = true;
	}
	
	public void off() {
		hinge.useMotor = false;
=======
public class Flipper : MonoBehaviour 
{
    [SerializeField]
	private float maxAngle = 20.0f;
    [SerializeField]
	private float flipTime = 1.0f;
	private string buttonName = "Fire1";

	private Quaternion initialOrientation;
	private Quaternion finalOrientation;
	private float t;

    [SerializeField]
	private float thrust;

	// Use this for initialization
	void Start () 
	{
		initialOrientation = transform.rotation;
		finalOrientation.eulerAngles = new Vector3 (initialOrientation.eulerAngles.x, initialOrientation.eulerAngles.y + maxAngle, initialOrientation.eulerAngles.z);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton(buttonName)) 
		{
			transform.rotation = Quaternion.Slerp (initialOrientation, finalOrientation, t/flipTime);
			t += Time.deltaTime;
			if (t > flipTime) 
			{
				t = flipTime;
			}
		} 
		else 
		{
			transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t/flipTime);
			t -= Time.deltaTime;
			if(t < 0)
			{
				t = 0;
			}
		}
	}
	void OnCollisionEnter (Collision col) 
	{
		if (col.gameObject.name == "Ball") 
		{
			//Debug.Log("It hits");
			col.rigidbody.AddForce(Vector3.forward * thrust);
		}
>>>>>>> origin/master
	}
}

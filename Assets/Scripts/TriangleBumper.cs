using UnityEngine;
using System.Collections;

public class TriangleBumper : MonoBehaviour
{
    [SerializeField]
	private float force = 1000.0f;
	
	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Rigidbody>() != null)
		{
			col.GetComponent<Rigidbody>().AddForce(transform.forward * force);
		}
	}
}

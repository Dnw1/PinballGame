using UnityEngine;
using System.Collections;

public class TriangleBumper : MonoBehaviour
{
	public float force = 1000.0f;
	public int scoreValue = 15;
	
	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Rigidbody>() != null)
		{
			col.GetComponent<Rigidbody>().AddForce(transform.forward * force);
		}
		ScoreDisplay.score += scoreValue;
	}
}

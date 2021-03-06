using UnityEngine;
using System.Collections;
//Soufyan Hassan

public class TriangleBumper : MonoBehaviour
{
	public float force = 1000.0f;
	public int scoreValue = 15;
    [SerializeField]
	private float force = 1000.0f;
	
	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Rigidbody>() != null)
		{
			col.GetComponent<Rigidbody>().AddForce(transform.forward * force);
		}
		ScoreDisplay.score += scoreValue;
	}
}

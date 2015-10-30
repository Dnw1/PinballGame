using UnityEngine;
using System.Collections;

public class TriangleBumper : MonoBehaviour
{
<<<<<<< HEAD
	public float force = 1000.0f;
	public int scoreValue = 15;
=======
    [SerializeField]
	private float force = 1000.0f;
>>>>>>> origin/master
	
	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Rigidbody>() != null)
		{
			col.GetComponent<Rigidbody>().AddForce(transform.forward * force);
		}
<<<<<<< HEAD
		ScoreDisplay.score += scoreValue;
=======
>>>>>>> origin/master
	}
}

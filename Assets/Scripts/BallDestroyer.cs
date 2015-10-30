using UnityEngine;
using System.Collections;

public class BallDestroyer : MonoBehaviour {

	public GameObject spawnedObject;
	public int counter = 0;

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		Debug.Log ("It got destroyed");
		Vector3 spawnPosition = new Vector3 (50, 2, 51);
		if (counter < 4) 
		{
			Instantiate (spawnedObject, spawnPosition, Quaternion.identity);
			counter =+ 1;
		}
	}
}

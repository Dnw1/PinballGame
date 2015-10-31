using UnityEngine;
using System.Collections;
using UnityEditor.Audio;
//Soufyan Hassan

public class Bumper : MonoBehaviour
{
    [SerializeField]
    private float force = 100.0f;
    [SerializeField]
    private float forceRadius = 1.0f;
    private int scoreValue = 15;
    //public AudioClip bumperSound;
    private AudioSource source;

    void Start()
    {
        source = this.gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        foreach (Collider col in Physics.OverlapSphere(transform.position, forceRadius))
        {
            if (col.GetComponent<Rigidbody>())
            {
                source.Play();
                col.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, forceRadius);
            }
        }

        ScoreManager.score += scoreValue;
        
    }
}

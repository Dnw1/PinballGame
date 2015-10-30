<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;   

public class Bumper : MonoBehaviour
{
    public float force = 100.0f;
    public float forceRadius = 1.0f;
    public int scoreValue = 15;
    //public AudioClip bumperSound;

    void OnCollisionEnter()
    {
        foreach (Collider col in Physics.OverlapSphere(transform.position, forceRadius))
        {
            if (col.GetComponent<Rigidbody>())
            {
                col.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, forceRadius);
            }
        }

        ScoreDisplay.score += scoreValue;
    }
=======
﻿using UnityEngine;
using System.Collections;
using UnityEditor.Audio;

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
>>>>>>> origin/master
}
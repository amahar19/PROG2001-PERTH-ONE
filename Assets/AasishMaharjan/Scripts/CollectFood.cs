using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFood : MonoBehaviour
{
    public AudioSource collectSound;
    

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoreManagerAasish.theScore += 50; // Increment the score
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerAasish : MonoBehaviour
{
    public Text scoreText; // Change the type to Text
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore += 50;
        scoreText.text = "SCORE: " + theScore; // Access the text property directly
        Destroy(gameObject);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectFood : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject congratulationsPanel;
    public Text scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HungryBoy"))
        {
            collectSound.Play();
            ScoreManagerAasish.theScore += 50; // Increment the score
            Destroy(gameObject);

            // Check if all collectibles are collected
            if (AreAllCollectiblesCollected())
            {
                Debug.Log("All collectibles collected!");
                ShowCongratulationsPanel();
            }
        }
    }

    bool AreAllCollectiblesCollected()
    {
        // Get all GameObjects with the "Collectible" tag
        GameObject[] collectibles = GameObject.FindGameObjectsWithTag("CollectiblesAasish");
        Debug.Log("Number of collectibles: " + collectibles.Length);
        // If no collectibles are left in the scene, return true

        return collectibles.Length == 0;
    }

    void ShowCongratulationsPanel()
    {
        Debug.Log("Showing congratulations panel!");
        congratulationsPanel.SetActive(true);
        scoreText.text = "Final Score: " + ScoreManagerAasish.theScore;
    }
}

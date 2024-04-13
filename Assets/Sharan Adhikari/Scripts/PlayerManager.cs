using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static int numberOfSpheres;
    public Text spheresText;

    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        numberOfSpheres = 0;

        // Find the Text component in children
        spheresText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        if (spheresText != null)
        {
            spheresText.text = "Spheres: " + numberOfSpheres;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerAasish : MonoBehaviour
{
    public Text scoreText; // Change the type to Text
    public static int theScore;
    

    void Update()
    {
        
        
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore; // Access the text property directly
        
    }
}


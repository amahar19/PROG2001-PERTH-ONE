using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI LivesText;

    public GameObject GameOverScreen;

    private void Awake()
    {
        GameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LivesText.text = HealthScript.playerLives.ToString("Lives:" + HealthScript.playerLives);

        if (HealthScript.playerLives == 0)
        {
            GameOverScreen.SetActive(true);
            
        }
        
    }

    public void ResetUI()
    {
        GameOverScreen.SetActive(false);
        HealthScript.playerLives = 1;
    }
}

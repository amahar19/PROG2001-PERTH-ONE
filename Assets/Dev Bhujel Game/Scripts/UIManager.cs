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
        
    public void ResetUI()
    {
        GameOverScreen.SetActive(false);
        HealthScript.playerLives = 1;
    }
}

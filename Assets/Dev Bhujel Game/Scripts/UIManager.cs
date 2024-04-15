using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI LivesText;

    // Update is called once per frame
    void Update()
    {
        LivesText.text = HealthScript.playerLives.ToString("Lives: " + HealthScript.playerLives);
        
    }
}

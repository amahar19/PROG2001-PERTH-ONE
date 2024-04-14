using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic backgroundMusic;
    
    void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "homeAasish")
        {
            // Destroy the background music object if not needed in the home scene
            Destroy(gameObject);
        }
    }
}

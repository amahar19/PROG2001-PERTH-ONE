using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuKowsar : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene(16);
    }
    public void Reset()
    {
        SceneManager.LoadScene(16);
        print("Working");
    }
}

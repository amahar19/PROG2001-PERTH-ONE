using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuKowsar : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene(13);
    }
    public void Reset()
    {
        SceneManager.LoadScene(13);
        
    }
    public void Quit()
    {
        SceneManager.LoadScene(1);
         }
    public void Menu()
    {
        SceneManager.LoadScene(14);
        
    }
}

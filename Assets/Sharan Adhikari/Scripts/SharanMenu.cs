using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharanMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SharanGame");

 }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void HelpGame()
    {
        SceneManager.LoadScene("SharanHelp");
    }

}

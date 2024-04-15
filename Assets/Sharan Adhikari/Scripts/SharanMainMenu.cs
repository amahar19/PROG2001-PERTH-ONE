using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharanMainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SharanGame");

 }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }

}

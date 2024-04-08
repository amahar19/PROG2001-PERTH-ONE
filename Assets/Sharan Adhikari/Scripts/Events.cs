using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
   public void ReplayGame()
   {
    SceneManager.LoadScene("MyGame");
   }
   
   public void QuitGame()
   {
    Application.Quit();
   }
}

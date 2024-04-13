using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
   public void ReplayGame()
   {
    SceneManager.LoadScene("SharanGame");
   }
   
   public void QuitGame()
   {
      SceneManager.LoadScene("SharanMenu");
   }

   public void HelpGame()
   {
      SceneManager.LoadScene("SharanHelp");
   }
}

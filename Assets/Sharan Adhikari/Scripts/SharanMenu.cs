using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< Updated upstream
public class SharanMenu : MonoBehaviour
=======
<<<<<<<< HEAD:Assets/AasishMaharjan/Scripts/SharanMainMenu.cs
public class SharanMainMenu : MonoBehaviour
========
public class SharanMenu : MonoBehaviour
>>>>>>>> e7064dc4532d260a0c7570d5e9295a5f76733194:Assets/Sharan Adhikari/Scripts/SharanMenu.cs
>>>>>>> Stashed changes
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

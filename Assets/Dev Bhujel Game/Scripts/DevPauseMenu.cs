using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevPauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
    }
    public void Home()
    {
        SceneLoader.LoadScene("Main Menu");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject cam;

    public GameObject helpPanel;

    private bool isShowingHelpPanel = false;

    void Update()
    {
       cam.transform.Rotate(0, 0.025f, 0);
    }

    public void ShowNames()
    {
        isShowingHelpPanel = !isShowingHelpPanel; // Toggle

        helpPanel.SetActive(isShowingHelpPanel);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
}

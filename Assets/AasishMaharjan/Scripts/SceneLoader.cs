using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ClickToPlay()
    {
        SceneManager.LoadScene(2);
    }


    public void ClickToHome()
    {
        SceneManager.LoadScene(0);
    }


    public void ClickToOptions()
    {
        SceneManager.LoadScene(5);
    }


    public void ClickToExit()
    {
        SceneManager.LoadScene(1);
    }


    public void ClickToTryAgain()
    {
        SceneManager.LoadScene(2);
    }


    public void ClickToPlayAgain()
    {
        SceneManager.LoadScene(2);
    }


    public void ClickToHelp()
    {
        SceneManager.LoadScene(6);
    }


    public void ClickToCredits()
    {
        SceneManager.LoadScene(7);
    }

    public void ClickToSound()
    {
        SceneManager.LoadScene(8);
    }

    public void ClickToMySceneHome()
    {
        SceneManager.LoadScene(1);
    }



}

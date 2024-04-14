using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Image soundOnIcon;
    public Image soundOffIcon;

    private bool muted;

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }

        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        muted = !muted;
        AudioListener.pause = muted;
        Save();
        UpdateButtonIcon();
    }

    public void UpdateButtonIcon()
    {
        soundOnIcon.enabled = !muted;
        soundOffIcon.enabled = muted;
    }

    public void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}

using UnityEngine;
using TMPro;

public class FadeAwayScriptAasish : MonoBehaviour
{
    public float fadeTime;
    private TextMeshProUGUI fadeAwayText;
    private float alphaValue;
    private float fadeAwayPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        fadeAwayText = GetComponent<TextMeshProUGUI>();
        fadeAwayPerSecond = 1f / fadeTime;
        alphaValue = fadeAwayText.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeTime > 0)
        {
            alphaValue -= fadeAwayPerSecond * Time.deltaTime;
            fadeAwayText.color = new Color(fadeAwayText.color.r, fadeAwayText.color.g, fadeAwayText.color.b, alphaValue);
            fadeTime -= Time.deltaTime;
        }
    }
}


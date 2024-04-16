using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerDev : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
   
    int score = 0;

    public GameObject playButton;
    public GameObject player;
    public TextMeshProUGUI scoreText;
    public GameObject winText;
    public int winScore;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(1f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }

    

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();

    if(score >= winScore)
        {
            winText.SetActive(true);

        }

    }


    public void GameStart()
    {
        
        

        player.SetActive(true);
        playButton.SetActive(false);

        StartCoroutine("SpawnObstacles");
        
        InvokeRepeating("ScoreUp", 2f, 1f);

    }
    
}

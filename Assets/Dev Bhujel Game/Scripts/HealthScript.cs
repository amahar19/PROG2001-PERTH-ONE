using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public static float playerLives = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Enemy")) 
        {
            playerLives--;
            Debug.Log(playerLives);

            if (playerLives == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

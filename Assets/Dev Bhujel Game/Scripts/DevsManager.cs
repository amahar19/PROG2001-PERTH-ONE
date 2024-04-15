using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevsManager : MonoBehaviour
{

    public GameObject playerToSpawn;


    public void SpawnPlayer()
    {
        Instantiate(playerToSpawn);
    }
    // Start is called before the first frame update
}

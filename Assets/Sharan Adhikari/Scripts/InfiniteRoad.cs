using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    public GameObject[] roadPrefabs;
    public float zSpawn = 0; //the x and y are not going to change
    public float roadLength = 30;
    public int numberOfRoads = 4;
    private  List<GameObject> activeRoads = new List<GameObject>();

    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i< numberOfRoads; i++)
       {
        if (i == 0)
            SpawnRoad(0);
            else
        SpawnRoad(Random.Range(0, roadPrefabs.Length));
       }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z - 35 > zSpawn - (numberOfRoads * roadLength))
        {
            SpawnRoad(Random.Range(0, roadPrefabs.Length));
            DeleteRoad();
        }
        
    }
    public void SpawnRoad(int roadIndex)
    {
       GameObject go =  Instantiate(roadPrefabs[roadIndex], transform.forward * zSpawn, transform.rotation);
       activeRoads.Add(go);
        zSpawn += roadLength;
    }
    private void DeleteRoad()
    {
        Destroy(activeRoads[0]);
        activeRoads.RemoveAt(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(20 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
         Debug.Log("OnTriggerEnter called");
        if(other.tag == "Player")
    {
         Debug.Log("Collision Detected with Player");
            PlayerManager.numberOfSpheres += 1;
            Debug.Log("Spheres: " + PlayerManager.numberOfSpheres);
            Destroy(gameObject);
        }


    }
}

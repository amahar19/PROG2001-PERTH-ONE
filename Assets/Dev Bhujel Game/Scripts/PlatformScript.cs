using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    Vector3 orginialPosition;


    // Start is called before the first frame update
    void Start()
    {
        //setting the orginial position of ground
        orginialPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //continuously moves the platform
        if (HealthScript.playerLives > 0)
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
        }
    }
<<<<<<< Updated upstream

    public void ResetPlatform()
    {
        transform.position = orginialPosition;
    }
=======
>>>>>>> Stashed changes
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CoinKowsar : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,30)* Time.deltaTime*5);
    }
}

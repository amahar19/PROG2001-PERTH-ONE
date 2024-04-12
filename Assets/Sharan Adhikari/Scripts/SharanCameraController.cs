using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharanCameraController : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }
    void StartController()
    {
        offset = transform.position - target.position;
    }

    

    // Update is called once per frame

    void lateUpdate()
    {
        Vector3 newPosition = new Vector3(transform.position.x,transform.position.y,offset.z+target.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition, 10 * Time.deltaTime);
    }
}

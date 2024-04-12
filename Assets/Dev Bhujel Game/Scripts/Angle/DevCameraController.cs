using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}

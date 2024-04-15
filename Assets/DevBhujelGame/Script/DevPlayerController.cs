using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevPlayerController : MonoBehaviour
{
    public float moveSpeed;

    float xInput;
    float yInput;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizotal");
        yInput = Input.GetAxis("Vertical");

        if(transform.position.y <= -5f)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(xInput * moveSpeed, 0, yInput * moveSpeed);
    }
}

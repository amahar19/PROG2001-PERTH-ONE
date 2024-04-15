using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public bool isOnGround;

    private Rigidbody myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        isOnGround = false;


        myPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //check for player input
        //When spacebar pressed, move along the y axis
        if (Input.GetButtonDown("Jump"))
        {
            myPlayer.velocity = new Vector3(0f, 5f, 0f);
            Debug.Log(" If Player presses the spacebar");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.CompareTag("Ground");
        isOnGround = true;
    }
}

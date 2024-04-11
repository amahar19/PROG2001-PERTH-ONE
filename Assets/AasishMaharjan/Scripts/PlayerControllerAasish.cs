using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerAasish : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;




    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();   
    }

    public void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        if(dir.magnitude >= 0.1f)
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }
    }
}

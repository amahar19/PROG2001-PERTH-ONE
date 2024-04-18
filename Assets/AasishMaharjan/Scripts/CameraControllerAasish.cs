using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerAasish : MonoBehaviour
{
    [SerializeField] float mouseSense = 250f;
    [SerializeField] float speed = 4f; // Define the speed variable here
    private Camera cam;
    private float xRotation = 0f;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float verticle = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * verticle + transform.right * horizontal;
        characterController.Move(movement * Time.deltaTime * speed);
        bool rightButton = Input.GetMouseButton(1);

        if (rightButton)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;
            //rotate camera based on y input
            xRotation = xRotation - mouseY;
            //limit camera rotation
            xRotation = Mathf.Clamp(xRotation, -70, 80);
            cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            //rotate player based on the x input
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}

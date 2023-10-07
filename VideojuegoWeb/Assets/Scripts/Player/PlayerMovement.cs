using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [Header("Joystick")]
    public Joystick joystick;
    private Vector3 desiredMovement;
    [Header("Movement stats")]
    public float speed;
    public float rotationSpeed;
    public float playerMass = 0.2f;
    private CharacterController controller;
    private bool grounded;
    private float gravity=0;

    private Action InputMethod; 

    void Start()
    {
        controller=GetComponent<CharacterController>();
        Debug.Log(SystemInfo.deviceType);
        //Determine inputType
        if (SystemInfo.deviceType == DeviceType.Desktop) 
        {
            InputMethod += keyboardController;
        }
        else 
        {
            InputMethod += joystickController;
            joystick.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        desiredMovement = Vector3.zero;
        InputMethod.Invoke();
        controller.Move(desiredMovement);

        //Apply gravity
        grounded = controller.isGrounded;
        if (grounded) 
        {
            gravity = 0;
        }
        else 
        {
            gravity -= 1;
        }
        controller.Move(new Vector3(0, gravity * playerMass * Time.deltaTime, 0));

        //Rotate to face movement direction
        if (desiredMovement.magnitude > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMovement), rotationSpeed);
        }
    }



    //Calculate movement vector depending on input
    void joystickController() 
    {
        desiredMovement = new Vector3(joystick.Horizontal, 0, joystick.Vertical) * speed * Time.deltaTime;
    }

    void keyboardController() 
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        desiredMovement = new Vector3(xInput, 0, yInput) * speed * Time.deltaTime;
    }
}

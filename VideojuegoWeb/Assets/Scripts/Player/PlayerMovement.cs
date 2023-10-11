using DG.Tweening;
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
    public bool grounded;
    public float gravity = 0;
    private float gravityMultiplyer = 1f;

    private Action InputMethod;

    public bool forceJoystick=false;

    void Start()
    {
        controller=GetComponent<CharacterController>();
        Debug.Log(SystemInfo.deviceType);
        //Determine inputType
        if (SystemInfo.deviceType == DeviceType.Desktop) 
        {
            InputMethod += KeyboardController;
            if (forceJoystick)
            {
                InputMethod += JoystickController;
                joystick.gameObject.SetActive(true);
            }
        }
        else 
        {
            InputMethod += JoystickController;
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
        gravity = 0;
        grounded = controller.isGrounded;
        if (grounded) 
        {
            gravity = 0;
        }
        else 
        {
            gravity -= 100;
        }
        controller.Move(new Vector3(0, gravity * gravityMultiplyer * playerMass * Time.deltaTime, 0));

        //Rotate to face movement direction
        if (desiredMovement.magnitude > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMovement*gravityMultiplyer), rotationSpeed);
        }
    }



    //Calculate movement vector depending on input
    void JoystickController() 
    {
        desiredMovement = new Vector3(joystick.Horizontal, 0, joystick.Vertical) * speed * Time.deltaTime;
    }

    void KeyboardController() 
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        desiredMovement = new Vector3(xInput, 0, yInput) * speed * Time.deltaTime;
    }

    //Change gravity method
    public void ChangeGravity() 
    {
        gravityMultiplyer = gravityMultiplyer * -1f;
        if (gravityMultiplyer > 0) 
        {
            transform.DORotate(new Vector3(0,transform.rotation.y,transform.rotation.z),1f);
            transform.localScale = Vector3.one;
        }
        else 
        {
            transform.DORotate(new Vector3(180, transform.rotation.y, transform.rotation.z), 1f);
            transform.localScale = -Vector3.one;
        }
        
    }
}

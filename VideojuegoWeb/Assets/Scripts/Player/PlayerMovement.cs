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


    public GameObject model;

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
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMovement), rotationSpeed);
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

        transform.localScale = new Vector3(1, 1 * gravityMultiplyer, 1);
        model.transform.DOLocalRotate(new Vector3(180, 0, 0), 0f, RotateMode.FastBeyond360);

        model.transform.DOLocalRotate(new Vector3(-180, 0, 0), 2f,RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.OutExpo).OnComplete(
            () => { /*transform.DOScale(new Vector3(1, 1 * gravityMultiplyer, 1), 0.1f); 
                    model.transform.DOLocalRotate(new Vector3(180, 0, 0), 0.5f, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear);*/ });
        //DOVirtual.Float(0, 180, 1, GravityRotation).OnComplete(() => { transform.localScale = new Vector3(1, 1 * gravityMultiplyer, 1); }); ;
        
    }

    public void GravityRotation(float x) 
    {
        Debug.Log(x);
        model.transform.localRotation = new Quaternion(x,model.transform.localRotation.y,model.transform.localRotation.z,model.transform.localRotation.w);
    }

}

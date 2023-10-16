using DG.Tweening;
using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Joystick")]
    public Joystick joystick;
    private Vector3 desiredMovement;
    [Header("Movement stats")]
    public float velocity=10;
    public float rotationSpeed=1;
    public float playerMass = 0.2f;
    private CharacterController controller;
    public bool grounded;
    public float gravity = 0;
    private float gravityMultiplyer = 1f;

    private Action InputMethod;

    public bool forceJoystick=false;


    public GameObject model;

    public bool blockPlayerMovement=false;

    private Camera cam;

    float xInput;
    float yInput;
    float speed;
    public float allowPlayerMovementThreshold=0.2f;


    void Start()
    {
        cam = Camera.main;
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
        CharacterMoveAndRotation();

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
    }


    void CharacterMoveAndRotation() 
    {
        InputMethod.Invoke();
        speed = new Vector2(xInput,yInput).sqrMagnitude;
        if (speed >= allowPlayerMovementThreshold && !blockPlayerMovement)
        {
            Vector3 forward = cam.transform.forward;
            Vector3 right = cam.transform.right;

            forward.y = 0f;
            right.y = 0f;

            forward.Normalize();
            right.Normalize();

            desiredMovement = (forward * yInput + right * xInput) * Time.deltaTime * velocity;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMovement), rotationSpeed);
            controller.Move(desiredMovement);
        }
    }

    //Calculate movement vector depending on input
    void JoystickController() 
    {
        xInput = joystick.Horizontal;
        yInput = joystick.Vertical;
    }

    void KeyboardController() 
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
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

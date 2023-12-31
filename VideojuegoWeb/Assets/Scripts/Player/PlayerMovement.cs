using DG.Tweening;
using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Joystick")]
    public Joystick joystick;
    private Vector3 desiredMovement;
    [Header("Movement stats")]
    //Sounds
    private AudioSource audioSource1;
    private AudioSource audioSource2;
    private AudioSource audioSource3;
    private AudioSource audioSource4;
    public float velocity = 10;
    public float rotationSpeed = 1;
    public float playerMass = 0.2f;
    private CharacterController controller;
    [SerializeField]
    private Transform feet;
    public bool grounded;
    public float gravity = 0;
    private float gravityMultiplyer = 1f;

    private Action InputMethod;

    public bool forceJoystick = false;


    public GameObject model;

    public bool blockPlayerMovement = false;

    private Camera cam;

    float xInput;
    float yInput;
    float speed;
    public float allowPlayerMovementThreshold = 0.2f;

    //Animations
    private Animator animator;
    
    private float fallStartHeight; // Variable para almacenar la altura desde la que comienza la ca�da
    public float minHeightForFallAnimation = 1f; // Altura m�nima para considerar una ca�da significativa
    public float timeBeforeFallAnimation = 0.5f; // Tiempo antes de activar la animaci�n de ca�da
    private float lastGroundedTime; // �ltimo tiempo en el que el jugador estuvo en el suelo

    //Sonidos
    private bool hasFallen = false;//variable de control para reporducir el sonido solo una vez.




    void Start()
    {
        cam = Camera.main;
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
        Debug.Log(SystemInfo.deviceType);

        //CargarSonidos
        audioSource1= GetComponents<AudioSource>()[0];
        audioSource2= GetComponents<AudioSource>()[1];

        //Determine inputType
        if (SystemInfo.deviceType == DeviceType.Handheld || Application.isMobilePlatform || forceJoystick)
        {
            InputMethod += JoystickController;
            joystick.gameObject.SetActive(true);
        }
        else
        {
            InputMethod += KeyboardController;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMoveAndRotation();
        checkGravity();
    }

    void checkGravity()
    {
        //Apply gravity
        Collider[] colliders = Physics.OverlapSphere(feet.position, 0.2f, 11);
        if (colliders.Length > 0)
        {
            grounded = true;
            animator.SetBool("Grounded", true);
            //Reestablece esta variable cuando toca suelo.
            hasFallen = false;
        }
        else
        {
            grounded = false;
            //animator.SetBool("Grounded", false);
        }
        //grounded = controller.isGrounded;
        if (grounded)
        {
            lastGroundedTime = Time.time; // Actualiza el tiempo en el que el jugador estuvo en el suelo
            gravity = 0;
            fallStartHeight = transform.position.y; // Actualiza la altura desde la que se inicia la ca�da
        }
        else
        {
            gravity -= 3;

            float currentHeight = transform.position.y;
            float fallHeight = fallStartHeight - currentHeight;

            if (fallHeight >= minHeightForFallAnimation && Time.time - lastGroundedTime > timeBeforeFallAnimation)
            {
                animator.SetBool("Grounded", false); // Activa la animaci�n de ca�da
                if (!hasFallen)
                    {
                        //Sonido caída:
                        audioSource1.Play();
                        hasFallen = true;
                    }
            }
        }
        controller.Move(new Vector3(0, gravity * gravityMultiplyer * playerMass * Time.deltaTime, 0));
    }


    void CharacterMoveAndRotation()
    {
        InputMethod.Invoke();
        speed = new Vector2(xInput, yInput).sqrMagnitude;
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
            animator.SetFloat("Speed", desiredMovement.magnitude);
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
        transform.position = transform.position + (new Vector3(0, 1, 0) * gravityMultiplyer);
        gravityMultiplyer = gravityMultiplyer * -1f;

        transform.localScale = new Vector3(1, 1 * gravityMultiplyer, 1);
        model.transform.DOLocalRotate(new Vector3(180, 0, 0), 0f, RotateMode.FastBeyond360);

        model.transform.DOLocalRotate(new Vector3(-180, 0, 0), 2f, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.OutExpo).OnComplete(
            () =>
            { /*transform.DOScale(new Vector3(1, 1 * gravityMultiplyer, 1), 0.1f); 
                    model.transform.DOLocalRotate(new Vector3(180, 0, 0), 0.5f, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear);*/
            });
        //DOVirtual.Float(0, 180, 1, GravityRotation).OnComplete(() => { transform.localScale = new Vector3(1, 1 * gravityMultiplyer, 1); }); ;

    }

    public void ResetGravity()
    {
        gravityMultiplyer = 1f;
        transform.localScale = Vector3.one;
    }

    public void GravityRotation(float x)
    {
        Debug.Log(x);
        model.transform.localRotation = new Quaternion(x, model.transform.localRotation.y, model.transform.localRotation.z, model.transform.localRotation.w);
    }

    public void ActivateEndLevelAnimation() 
    {
        animator.SetTrigger("EndAnimation");
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(feet.position, 0.2f);
    }

}

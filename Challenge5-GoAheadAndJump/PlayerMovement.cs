using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //[SeralizeField]
    // Public variables: 
    // movement speed, rotation speed, jump distance and sprint speed
    public float speed, rotationSpeed, jumpSpeed, sprintSpeed;

    //Private variables;
    //For movement input
    private Vector2 movementValue;

    //For horizontal rotation
    private float lookValue;

    //The rigidbody of the component
    private Rigidbody rb;

    //To check if its on the ground, check if its sprinting
    private bool IsGrounded, IsSprinting;

    //Called once at the beginning (empty)
    void Start()
    {

    }

    //Called when the script is instantiate
    private void Awake()
    {
        //Gets the Rigidbody component attached to the same GameObject
        rb = GetComponent<Rigidbody>();

        //locks and makes invisible the cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Move funtion
    public void OnMove(InputValue value)
    {
        //movement input multiplied by speed
        movementValue = value.Get<Vector2>() * speed;
    }

    //Moving the camera funtion
    public void OnLook(InputValue value)
    {
        //look input mult. by rotation speed
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }

    //Check if in ground
    public void Grounded()
    {
        //Sends a Ray down from the player and its true if it hits something
        IsGrounded = Physics.Raycast(transform.position, Vector3.down, 0.3f);
    }

    //jump Funtion
    public void OnJump(InputValue value)
    {
        //player jump if pressed and on ground
        if (value.isPressed && IsGrounded)
        {
            //Adds an upward force to make the player jump
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);

        }
    }
    
    //Sprint funtion
    public void OnSprint(InputValue value)
    {
        IsSprinting = value.isPressed;
    }
    // Update is called once per frame
    void Update()
    {
        //Check every frame if player is grounded
        Grounded();
        
        //For stop sprinting if not pressing
        if (Keyboard.current.leftShiftKey.isPressed)
            IsSprinting = true;
        else
            IsSprinting = false;

        //Local variable for changing speed
        float currentSpeed;
        
        // If sprint key is held, increase movement speed
        if (IsSprinting)
        {
            currentSpeed = sprintSpeed * speed;
        }
        else
        {
            currentSpeed = speed;
        }

        //Move the player 
        transform.Translate(
            movementValue.x * Time.deltaTime * currentSpeed,
            0,
            movementValue.y * Time.deltaTime * currentSpeed
        );

        //Rotates the camera
        transform.Rotate(0, lookValue * Time.deltaTime, 0);
        
       
           
    }
}

        //ignore this
        /* float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { transform.Translate(0, 0, speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { transform.Translate(0, 0, -speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(-speed * Time.deltaTime, 0, 0); }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { transform.Translate(speed * Time.deltaTime, 0, 0); }
        if (Input.GetKey(KeyCode.Space)){ transform.Translate(0, speed*Time.deltaTime, 0); }
        */
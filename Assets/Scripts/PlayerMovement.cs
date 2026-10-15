using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Transform camera;
    
    [Header("Movement Settings")]
    // [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] public float walkSpeed = 100f;
    [SerializeField] public float sprintSpeed = 5.0f;
    [SerializeField] public float jumpForce = 5.0f;
    [SerializeField] public float rotationSpeed = 10.0f;
    [Range(0f, 1f)] 
    [SerializeField] private float airControlMultiplier = 0.2f;
    
    [Header("Ground Check Settings")]
    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private float groundCheckDistance = 0.05f;
    [SerializeField] private LayerMask groundLayer;
    
    private Rigidbody rb;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 inputVector = Vector3.zero;
    private Vector2 moveInput = Vector2.zero;
    private Vector3 airMomentum = Vector3.zero;
    
    private Collider playerCollider;
    public bool isGrounded = false;
    public bool wasGroundedLastFrame;
    public bool canJump = false;
    private bool isHoldingJump = false;
    

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerCollider = GetComponent<CapsuleCollider>();
    }
    
    void Start()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        inputVector = movementValue.Get<Vector2>();
    }

    // public void OnJump(InputAction.CallbackContext context)
    // {
    //     // Debug.Log(canJump + " " + isGrounded);
    //     
    //     if (context.started)
    //     {
    //         isHoldingJump = true;
    //     }
    //     else if (context.canceled)
    //     {
    //         isHoldingJump = false;
    //     }
    //     
    // }
    
    void Update()
    {
        // if (isHoldingJump && canJump)
        // {
        //     rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
        //     canJump = false;
        // }
        
        CalculateMovementDirection();
        PlayerCheckGroundState();
    }

    void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
    }

    void CalculateMovementDirection()
    {
        Vector3 camForward = camera.forward;
        Vector3 camRight = camera.right;
        
        camForward.y = 0f;
        camRight.y = 0f;
        
        camForward.Normalize();
        camRight.Normalize();
        
        moveDirection = (camForward * inputVector.y) + (camRight * inputVector.x);
    }

    public void PlayerCheckGroundState()
    {
        wasGroundedLastFrame = isGrounded;
        canJump = isGrounded;
        
        
        float halfHeight = playerCollider.bounds.extents.y;
        // Debug.Log(halfHeight + " " + isGrounded);
        
        isGrounded = Physics.Raycast(transform.position, Vector3.down, halfHeight + groundCheckDistance, groundLayer);
        Debug.DrawRay(transform.position, Vector3.down * (halfHeight + groundCheckDistance), Color.red);

        if (wasGroundedLastFrame && !isGrounded)
        {
            airMomentum = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        }
    }

    private void MovePlayer()
    {
        Vector3 targetVelocity = new Vector3(moveDirection.x * walkSpeed, rb.linearVelocity.y, moveDirection.z * walkSpeed);
        rb.linearVelocity = targetVelocity;
    }

    private void RotatePlayer()
    {
        if (inputVector.sqrMagnitude > 0.01f && moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }
    
    
}

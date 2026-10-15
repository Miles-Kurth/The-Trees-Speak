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
    
    [Header("Movement Settings")]
    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private float groundCheckDistance = 0.1f;
    [SerializeField] private LayerMask groundLayer;
    
    private Rigidbody rb;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 inputVector = Vector3.zero;
    private Vector2 moveInput = Vector2.zero;
    private Vector3 airMomentum = Vector3.zero;
    
    private Collider playerCollider;
    private bool isGrounded = false;
    private bool wasGroundedLastFrame;
    

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

    void OnJump(InputValue jumpValue)
    {
        Debug.Log("Jump");
        if (!isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
        }
        //detection works, need to make it check if in air
    }
    
    void Update()
    {
        CalculateMovementDirection();
        CheckGroundState();
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

    private void CheckGroundState()
    {
        wasGroundedLastFrame = isGrounded;
        
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

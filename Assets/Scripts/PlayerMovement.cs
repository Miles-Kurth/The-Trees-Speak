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
    [Range(0f, 1f)] 
    [SerializeField] private float airControlMultiplier = 0.2f;
    
    [Header("Movement Settings")]
    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private float groundCheckRadius = 0.3f;
    [SerializeField] private LayerMask groundLayer;
    
    private Rigidbody rb;
    private Vector2 moveInput = Vector2.zero;
    private Vector3 airMomentum = Vector3.zero;
    private bool isGrounded;
    private bool wasGroundedLastFrame;

    private Vector3 cameraForward;
    private Vector3 cameraRight;
    
    

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 inputVector = movementValue.Get<Vector2>();
        moveInput = new Vector3(inputVector.x, 0f, inputVector.y);
        // moveHorizontal = moveInput.x;
        // moveVertical = moveInput.y;
    }

    void OnJump(InputValue jumpValue)
    {
        Debug.Log("Jump");
        rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }
    
    void Update()
    {
        cameraForward = camera.forward;
        cameraForward.y = 0;
        cameraForward.Normalize();
        cameraRight = camera.right;
        cameraRight.y = 0;
        cameraRight.Normalize();
        
        
        
        
        Vector3 localMovement = new Vector3(moveInput.x, 0f, moveInput.y);
        Vector3 worldMovement = transform.TransformDirection(localMovement);
        
        
    }

    void FixedUpdate()
    {
        CheckGroundState();
        MovePlayer();
    }

    private void CheckGroundState()
    {
        wasGroundedLastFrame = isGrounded;
        // groundCheckPoint.position = transform.position + new Vector3(0, -1f, 0f);
        
        isGrounded = Physics.CheckSphere(groundCheckPoint.position, groundCheckRadius, groundLayer);

        if (wasGroundedLastFrame && !isGrounded)
        {
            airMomentum = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        }
    }

    private void MovePlayer()
    {
        Vector3 moveDirection = cameraForward * moveInput.y + cameraRight * moveInput.x;
        moveDirection.Normalize();
        
        Vector3 targetVelocity;

        if (isGrounded)
        {
            if (moveInput.sqrMagnitude < 0.01f)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
            
            targetVelocity = moveDirection * walkSpeed;
        }
        else
        {
            Vector3 airControlForce = moveInput * (walkSpeed * airControlMultiplier);
            
            targetVelocity = airMomentum + airControlForce;
            
            targetVelocity = Vector3.ClampMagnitude(targetVelocity, walkSpeed);
        }

        if (moveInput.sqrMagnitude > 0.01f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveInput.normalized, Vector3.up);
            // rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, Time.deltaTime * 15f));
            rb.MoveRotation(rb.rotation * targetRotation);
        }
        
        targetVelocity.y = rb.linearVelocity.y;
        
        rb.linearVelocity = targetVelocity;
        
        transform.rotation *= Quaternion.Euler(0f, targetVelocity.y, 0f);
        
        
        // transform.Translate(moveDirecton * (walkSpeed * (moveSpeed * Time.deltaTime)), Space.World);
        // rb.AddForce(moveDirection * (walkSpeed * (moveSpeed * Time.deltaTime) ), ForceMode.VelocityChange);
        // rb.linearVelocity = new Vector3(moveInput.x * walkSpeed, rb.linearVelocity.y, rb.linearVelocity.z);
        // Vector3 targetPosition = rb.position * moveInput * (walkSpeed * Time.deltaTime);
        // rb.MovePosition(targetPosition);
    }
}

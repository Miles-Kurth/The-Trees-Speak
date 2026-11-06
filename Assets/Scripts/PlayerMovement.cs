using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public PlayerBuoyancy buoyancy;
    
    public Transform camera;
    public Image Stamina;
    private float stamNum = 400;
    private float stamSize = 425f;
    
    [Header("Movement Settings")]
    // [SerializeField] private float moveSpeed = 2.0f;
    private float walkSpeed = 4.0f;
    private float sprintSpeed = 8.0f;
    private float waterSpeed = 2.5f;
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
    private bool isSprinting = false;
    private float sprintRechargeFactor = 0f;
    private float sprintDrainFactor = 0f;
    
    private PlayerInput playerInput;
    private InputAction sprintAction;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerCollider = GetComponent<CapsuleCollider>();
        
        playerInput = GetComponent<PlayerInput>();
        sprintAction = playerInput.actions["Sprint"];
    }
    
    void Start()
    {
    }

    void UpdateStamina()
    {
        if (stamNum > 400)
        {
            stamNum = 400;
            sprintRechargeFactor = 0f;
            sprintDrainFactor = 0f;
        }

        if (stamNum < 0)
        {
            stamNum = 0;
        }
        if (stamNum > 0)
        {
            stamSize = 425 * (stamNum / 400f);
            Stamina.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, stamSize);
        }

        if (sprintRechargeFactor < 0f)
        {
            sprintRechargeFactor = 0f;
        }
        if (sprintDrainFactor < 0f)
        {
            sprintDrainFactor = 0f;
        }
    }

    void OnMove(InputValue movementValue)
    {
        inputVector = movementValue.Get<Vector2>();
    }
    
    void Update()
    {
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
        
        isGrounded = Physics.Raycast(transform.position, Vector3.down, halfHeight + groundCheckDistance, groundLayer);
        Debug.DrawRay(transform.position, Vector3.down * (halfHeight + groundCheckDistance), Color.red);

        if (wasGroundedLastFrame && !isGrounded)
        {
            airMomentum = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        }
    }

    private void MovePlayer()
    {
        isSprinting = sprintAction.ReadValue<float>() > 0f;
        
        float currentSpeed;
        if (isSprinting && moveDirection != Vector3.zero)
        {
            DecreaseStamina();
            
            if (stamNum > 0)
            {
                currentSpeed = sprintSpeed;
                sprintRechargeFactor -= 2f;
                sprintDrainFactor += 0.02f;
            }
            else
            {
                currentSpeed = walkSpeed;
                sprintDrainFactor -= 2f;
            }
        } 
        else
        {
            currentSpeed = walkSpeed;
            if (stamNum < 400) IncreaseStamina();
            sprintRechargeFactor += 0.02f;
            sprintDrainFactor -= 2f;
        }
        UpdateStamina();
        // Debug.Log("Stamina: " + stamNum);
        
        if (!isGrounded && buoyancy.inWater)
        {
            isSprinting = false;
            currentSpeed = waterSpeed;
        }
        
        // Vector3 targetVelocity = new Vector3(moveDirection.x * currentSpeed, rb.linearVelocity.y, moveDirection.z * currentSpeed);
        // rb.linearVelocity = targetVelocity;
        
        
        // 1. Calculate what your horizontal target velocity should be based on input
        Vector3 horizontalTarget = new Vector3(moveDirection.x * currentSpeed, 0, moveDirection.z * currentSpeed);

        // 2. Isolate your current horizontal velocity
        Vector3 horizontalVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);

        // 3. Smoothly step the current velocity toward the target velocity
        // Adjust 'decelerationSpeed' to control how long it takes to stop (e.g., try 15f to 25f)
        float decelerationSpeed = 30f; 
        Vector3 horizontalNew = Vector3.MoveTowards(horizontalVelocity, horizontalTarget, decelerationSpeed * Time.fixedDeltaTime);
        rb.linearVelocity = new Vector3(horizontalNew.x, rb.linearVelocity.y, horizontalNew.z);
        
    }

    private void RotatePlayer()
    {
        if (inputVector.sqrMagnitude > 0.01f && moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }

    private void IncreaseStamina()
    {
        double change = 0.872 + (Math.Pow(2, ((1 / 2.69) * sprintRechargeFactor) - 3.21));
        stamNum += (float)change;
        Debug.Log("Increase: " + change + "   Time: " + sprintRechargeFactor);
    }

    private void DecreaseStamina()
    {
        double change = 0.83 - (Math.Pow(2, ((1 / 1.75) * sprintDrainFactor) - 7.75));
        stamNum -= (float)change;
        Debug.Log("Decrease: " + change + "   Time: " + sprintDrainFactor);
    }

    void OnSprint(InputValue value)
    {
        if (sprintAction.WasPressedThisFrame())
        {
            stamNum -= 10;
        }
    }
    
}

using UnityEngine;
using UnityEngine.InputSystem;

public class ContinuousJump : MonoBehaviour
{
    public PlayerMovement moveReference;
    
    [SerializeField] private InputActionReference jumpActionReference;
    private Rigidbody rb;
    private bool isJumping = false;
    private bool jumpLockedOut = false; // Tracks if we are physically blocked from jumping again

    private void Awake()
    {
        moveReference = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        jumpActionReference.action.Enable();
    }

    void OnDisable()
    {
        jumpActionReference.action.Disable();
    }

    void Update()
    {
        // 1. If we are falling or standing still, we are definitely done rising
        if (isJumping && rb.linearVelocity.y <= 0.1f)
        {
            isJumping = false;
        }

        // 2. ONLY clear the lockout once your external script also agrees you are airborne.
        // This ensures the player cannot fire another jump until they have completely left the ground.
        if (jumpLockedOut && !moveReference.isGrounded && rb.linearVelocity.y > 0.5f)
        {
            jumpLockedOut = false;
        }
        
        // 3. Read continuous hold input
        bool isHoldingJump = jumpActionReference.action.IsInProgress();

        // 4. Added !jumpLockedOut requirement
        if (isHoldingJump && moveReference.isGrounded && !isJumping && !jumpLockedOut)
        {
            PerformJump();
        }
    }

    private void PerformJump()
    {
        isJumping = true;
        jumpLockedOut = true; // Actively locks inputs until physics pulls us away from the floor
        
        Debug.Log("jumping ");
        
        // Clear vertical velocity for absolute uniformity
        Vector3 velocity = rb.linearVelocity;
        velocity.y = 0f;
        rb.linearVelocity = velocity;
        
        rb.AddForce(Vector3.up * moveReference.jumpForce, ForceMode.Impulse);
    }
}
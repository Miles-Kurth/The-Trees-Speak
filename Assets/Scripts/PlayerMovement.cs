using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Transform camera;
    
    private float moveSpeed = 2.0f;
    public float walkSpeed = 5.0f;
    public float sprintSpeed = 5.0f;
    public float jumpForce = 5.0f;
    
    private Vector2 moveInput;
    private float moveHorizontal;
    private float moveVertical;
    
    private Vector3 moveDirecton;
    private Vector3 cameraForward;
    private Vector3 cameraRight;
    
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        moveInput = movementValue.Get<Vector2>();
        moveHorizontal = moveInput.x;
        moveVertical = moveInput.y;
    }

    void OnJump(InputValue jumpValue)
    {
        Debug.Log("Jump");
        rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }
    
    // Update is called once per frame
    void Update()
    {
        cameraForward = camera.forward;
        cameraForward.y = 0;
        cameraForward.Normalize();
        cameraRight = camera.right;
        cameraRight.y = 0;
        cameraRight.Normalize();
        
        
        moveDirecton = cameraForward * moveInput.y + cameraRight * moveInput.x;
        moveDirecton.Normalize();
        
        Vector3 localMovement = new Vector3(moveInput.x, 0f, moveInput.y);
        Vector3 worldMovement = transform.TransformDirection(localMovement);
        
        transform.Translate(moveDirecton * (moveSpeed * Time.deltaTime), Space.World);
        // Debug.Log(moveDirecton);
    }

    void LateUpdate()
    {
        
    }
}

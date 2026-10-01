using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Transform camera;
    
    [SerializeField] public float moveSpeed = 5.0f;
    [SerializeField] public float jumpForce = 5.0f;
    
    private Vector2 moveInput;
    private Vector3 moveDirecton;
    private Vector3 cameraAngle;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraAngle = camera.rotation.eulerAngles;
        moveDirecton = cameraAngle * moveInput.y + cameraAngle * moveInput.x;
        moveDirecton.Normalize();
        
        Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y);
        
        transform.Translate(movement);
    }

    void OnMove(InputValue movementValue)
    {
        moveInput = movementValue.Get<Vector2>();
    }

    void OnJump(InputValue jumpValue)
    {
        Debug.Log("Jump");
        rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }
}

using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform target; //target is player
    public float smoothTime = 0.3f;
    
    private Vector3 velocity = Vector3.zero;

    private Vector2 mouseDelta;
    private float mouseX;
    private float mouseY;
    public float mouseSensitivity = 0.001f;
    
    private Vector3 rotateDirection;
    private float rotationVertical = 0f;
    private float rotationHorizontal = 0f;
    private float xRotation = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mouseDelta = Vector2.zero;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    public void OnLook(InputValue value)
    {
        mouseDelta = value.Get<Vector2>();
    }

    void Update()
    {
        // Debug.Log($"Mouse X Delta: {mouseDelta.x}, Mouse Y Delta: {mouseDelta.y}");
        mouseX = mouseDelta.x * mouseSensitivity;
        mouseY = mouseDelta.y * mouseSensitivity;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80, 80);
        
        // rotateDirection = new Vector3(-mouseY, mouseDelta.x, 0f);
        
        
        // rotationVertical = transform.eulerAngles.x + rotateDirection.x;
        // Debug.Log("Angle: " + rotationVertical);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Vector3 targetPosition = target.position;
        
        // transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        target.Rotate(Vector3.up, mouseX);
        
        // transform.Rotate(rotateDirection);
        // transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        
    }
    
}

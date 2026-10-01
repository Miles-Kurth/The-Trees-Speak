using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform target; //target is player
    public float smoothTime = 0.3f;
    
    private Vector3 velocity = Vector3.zero;

    private Vector2 mouseDelta;
    public float mouseSensitivity = 20f;
    private Vector3 rotateDirection;
    
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
        Debug.Log($"Mouse X Delta: {mouseDelta.x}, Mouse Y Delta: {mouseDelta.y}");
        rotateDirection = new Vector3(-mouseDelta.y, mouseDelta.x, 0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = target.position;
        
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        transform.Rotate(rotateDirection);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 0);
    }
    
    
}

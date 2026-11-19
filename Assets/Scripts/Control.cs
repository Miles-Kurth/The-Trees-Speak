using System;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-100)]
public class Control : MonoBehaviour
{
    public bool playerCanMove = true;
    public bool playerCanLook = true;

    public bool cursorCanMove = true;


    public bool escPressed = false;
    public bool gamePaused = false;
    public bool canPause = true;


    private void Start()
    {
        playerCanLook = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null)
        {
            if (Keyboard.current.escapeKey.wasPressedThisFrame) escPressed = true;
            else escPressed = false;
        }
        
    }
    
    
}

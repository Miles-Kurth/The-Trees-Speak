using UnityEngine;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class QuitGame : MonoBehaviour
{
    void Update()
    {
        bool escPressed = false;

        // Check using New Input System
        #if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            escPressed = true;
        }
        // Fallback to Old Input System
        #else
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escPressed = true;
        }
        #endif

        if (escPressed)
        {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        }
    }
}
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class QuitGame : MonoBehaviour
{
    public Button Resume;
    public TextMeshProUGUI ResumeText;
    public Button Options;
    public TextMeshProUGUI OptionsText;
    public Button Quit;
    public TextMeshProUGUI QuitText;
    public Image Inventory;
    void Start()
    {
        Resume.image.enabled = false;
        ResumeText.enabled = false;
        Options.image.enabled = false;
        OptionsText.enabled = false;
        Quit.image.enabled = false;
        QuitText.enabled = false;
    }
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

        if (escPressed && !Inventory.enabled)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Resume.image.enabled = true;
            ResumeText.enabled = true;
            Options.image.enabled = true;
            OptionsText.enabled = true;
            Quit.image.enabled = true;
            QuitText.enabled = true;
        }
    }

    public void end()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Resume.image.enabled = false;
        ResumeText.enabled = false;
        Options.image.enabled = false;
        OptionsText.enabled = false;
        Quit.image.enabled = false;
        QuitText.enabled = false;
    }
}
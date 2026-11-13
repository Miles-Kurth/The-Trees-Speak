using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

[DefaultExecutionOrder(-100)]
public class QuitGame : MonoBehaviour
{
    public Button Resume;
    public TextMeshProUGUI ResumeText;
    public Button Options;
    public TextMeshProUGUI OptionsText;
    public Button Quit;
    public TextMeshProUGUI QuitText;
    public Image Inventory;
    public bool waitEsc = false;
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
        // Debug.Log(Inventory.enabled);
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

        IEnumerator WaitUntilEscReleased()
        {
            yield return new WaitUntil(() => Keyboard.current.escapeKey.wasReleasedThisFrame);
            waitEsc = false;
        }
        
        //When inventory closed
        if (escPressed && Inventory.enabled && !waitEsc)
        {
            Debug.Log("Inventory closed");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            waitEsc = true;
            StartCoroutine(WaitUntilEscReleased());
        }
        
        //Open pause screen
        if (escPressed && !Inventory.enabled && !waitEsc)
        {
            Debug.Log("Open pause screen");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Resume.image.enabled = true;
            ResumeText.enabled = true;
            Options.image.enabled = true;
            OptionsText.enabled = true;
            Quit.image.enabled = true;
            QuitText.enabled = true;
            waitEsc = true;
            StartCoroutine(WaitUntilEscReleased());
        }
        
        //Close pause screen
        if (escPressed && Resume.enabled && !waitEsc)
        {
            resume();
            waitEsc = true;
            StartCoroutine(WaitUntilEscReleased());
        }

        
        
    }

    public void End()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    public void resume()
    {
        Debug.Log("resume called");
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
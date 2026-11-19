using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

[DefaultExecutionOrder(-99)]
public class QuitGame : MonoBehaviour
{
    public Control control;
    
    public Button resumeButton;
    public TextMeshProUGUI ResumeText;
    public Button optionsButton;
    public TextMeshProUGUI OptionsText;
    public Button quitButton;
    public TextMeshProUGUI QuitText;
    public Image inventory;
    
    public bool waitEsc = false;
    
 
    void Start()
    {
        resumeButton.image.enabled = false;
        ResumeText.enabled = false;
        optionsButton.image.enabled = false;
        OptionsText.enabled = false;
        quitButton.image.enabled = false;
        QuitText.enabled = false;
    }
    void Update()
    {
        // Debug.Log(Inventory.enabled);
        bool escPressed = control.escPressed;



        IEnumerator WaitUntilEscReleased()
        {
            yield return new WaitUntil(() => Keyboard.current.escapeKey.wasReleasedThisFrame);
            waitEsc = false;
        }
        
        //When inventory closed
        if (escPressed && inventory.enabled && !waitEsc)
        {
            Debug.Log("Inventory closed");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            waitEsc = true;
            StartCoroutine(WaitUntilEscReleased());
        }
        
        //Open pause screen
        if (escPressed && !inventory.enabled && !waitEsc)
        {
            Debug.Log("Open pause screen");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            resumeButton.image.enabled = true;
            ResumeText.enabled = true;
            optionsButton.image.enabled = true;
            OptionsText.enabled = true;
            quitButton.image.enabled = true;
            QuitText.enabled = true;
            waitEsc = true;
            StartCoroutine(WaitUntilEscReleased());
        }
        
        //Close pause screen
        if (escPressed && resumeButton.enabled && !waitEsc)
        {
            Resume();
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

    public void Resume()
    {
        Debug.Log("resume called");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        resumeButton.image.enabled = false;
        ResumeText.enabled = false;
        optionsButton.image.enabled = false;
        OptionsText.enabled = false;
        quitButton.image.enabled = false;
        QuitText.enabled = false;
    }
}
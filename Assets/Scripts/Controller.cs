using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Image Wood;

    private bool startTrack = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        while (startTrack == true)
        {
            float mouseX = Mouse.current.position.ReadValue().x;
            float mouseY = Mouse.current.position.ReadValue().y;
            Wood.rectTransform.anchoredPosition = new Vector2(mouseX, mouseY);
            Debug.Log(mouseX);
            Debug.Log(mouseY);
        }
    }

    public void WoodClick()
    {
        startTrack = true;
    }
}

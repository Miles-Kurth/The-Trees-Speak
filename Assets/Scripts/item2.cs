using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System.Collections;
public class Item2 : MonoBehaviour
{
    public Button AppleButton;
    public RectTransform AppleRect;
    private bool startTrack = false;
    private bool hasClicked = false;

    private int x = 0;
    private int y = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTrack == true)
        {
            float mouseX = Mouse.current.position.ReadValue().x;
            float mouseY = Mouse.current.position.ReadValue().y;
            AppleRect.anchoredPosition = new Vector2((float)(mouseX * 0.417)-50, (float)(mouseY * 0.417)-300);
        }
    }

    public void Apple()
    {
        startTrack = true;
        hasClicked = true;
    }
}

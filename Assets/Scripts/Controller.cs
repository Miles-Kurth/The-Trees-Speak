using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour
{
    public Image Wood;

    private bool startTrack = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float mouseX = Mouse.current.position.ReadValue().x;
        Debug.Log(mouseX);
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Mouse.current.position.ReadValue().x;
        float mouseY = Mouse.current.position.ReadValue().y;
        Wood.rectTransform.anchoredPosition = new Vector2(mouseX, mouseY);
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
    }
    public void WoodClick()
    {
        startTrack = true;
    }
}

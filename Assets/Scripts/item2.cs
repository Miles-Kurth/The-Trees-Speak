using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System.Collections;
public class Item2 : MonoBehaviour
{
    public Button AppleButton;
    public RectTransform AppleRect;
    public Image Inv;
    private bool startTrack = false;
    private bool hasClicked = false;

    public static int x = 0;
    private int y = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AppleButton.image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (AppleRect.anchoredPosition.y == -145)
        {
            AppleButton.image.enabled = true;
        }
        else if (Inv.enabled == false)
        {
            AppleButton.image.enabled = false;
        }
        if (startTrack == true)
        {
            float mouseX = Mouse.current.position.ReadValue().x;
            float mouseY = Mouse.current.position.ReadValue().y;
            AppleRect.anchoredPosition = new Vector2((float)(mouseX * 0.417)-400, (float)(mouseY * 0.417)-225);
        }

        if (hasClicked == true && startTrack == false)
        {
            if (AppleRect.anchoredPosition.y < -15)
            {


                if (AppleRect.anchoredPosition.x < -160)
                {
                    x = 1;
                }
                else if (AppleRect.anchoredPosition.x < -120)
                {
                    x = 2;
                }
                else if (AppleRect.anchoredPosition.x < -80)
                {
                    x = 3;
                }
                else if (AppleRect.anchoredPosition.x < -40)
                {
                    x = 4;
                }
                else if (AppleRect.anchoredPosition.x < 0)
                {
                    x = 5;
                }
                else if (AppleRect.anchoredPosition.x < 40)
                {
                    x = 6;
                }
                else if (AppleRect.anchoredPosition.x < 80)
                {
                    x = 7;
                }
                else if (AppleRect.anchoredPosition.x < 120)
                {
                    x = 8;
                }
                else if (AppleRect.anchoredPosition.x < 160)
                {
                    x = 9;
                }
                else if (AppleRect.anchoredPosition.x > 159)
                {
                    x = 10;
                }

                if (AppleRect.anchoredPosition.y < -125)
                {
                    y = 1;
                }
                else if (AppleRect.anchoredPosition.y < -85)
                {
                    y = 2;
                }
                else if (AppleRect.anchoredPosition.y < -45)
                {
                    y = 3;
                }
                else if (AppleRect.anchoredPosition.y > -46)
                {
                    y = 4;
                }

                if (x == 1 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(-180, -145);
                }
                else if (x == 2 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(-140, -145);
                }
                else if (x == 3 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(-100, -145);
                }
                else if (x == 4 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(-60, -145);
                }
                else if (x == 5 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(-20, -145);
                }
                else if (x == 6 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(20, -145);
                }
                else if (x == 7 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(60, -145);
                }
                else if (x == 8 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(100, -145);
                }
                else if (x == 9 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(140, -145);
                }
                else if (x == 10 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(180, -145);
                }

                if (x == 1 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(-180, -105);
                }
                else if (x == 2 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(-140, -105);
                }
                else if (x == 3 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(-100, -105);
                }
                else if (x == 4 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(-60, -105);
                }
                else if (x == 5 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(-20, -105);
                }
                else if (x == 6 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(20, -105);
                }
                else if (x == 7 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(60, -105);
                }
                else if (x == 8 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(100, -105);
                }
                else if (x == 9 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(140, -105);
                }
                else if (x == 10 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(180, -105);
                }

                if (x == 1 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(-180, -65);
                }
                else if (x == 2 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(-140, -65);
                }
                else if (x == 3 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(-100, -65);
                }
                else if (x == 4 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(-60, -65);
                }
                else if (x == 5 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(-20, -65);
                }
                else if (x == 6 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(20, -65);
                }
                else if (x == 7 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(60, -65);
                }
                else if (x == 8 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(100, -65);
                }
                else if (x == 9 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(140, -65);
                }
                else if (x == 10 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(180, -65);
                }

                if (x == 1 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(-180, -25);
                }
                else if (x == 2 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(-140, -25);
                }
                else if (x == 3 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(-100, -25);
                }
                else if (x == 4 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(-60, -25);
                }
                else if (x == 5 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(-20, -25);
                }
                else if (x == 6 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(20, -25);
                }
                else if (x == 7 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(60, -25);
                }
                else if (x == 8 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(100, -25);
                }
                else if (x == 9 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(140, -25);
                }
                else if (x == 10 && y == 4)
                {
                    AppleRect.anchoredPosition = new Vector2(180, -25);
                }
            }
            else if (AppleRect.anchoredPosition.y > -14)
            {
                if (AppleRect.anchoredPosition.x < -20)
                {
                    x = 1;
                }
                else if (AppleRect.anchoredPosition.x < 20)
                {
                    x = 2;
                }
                else if (AppleRect.anchoredPosition.x > 19)
                {
                    x = 3;
                }
                if (AppleRect.anchoredPosition.y < 70)
                {
                    y = 1;
                }
                else if (AppleRect.anchoredPosition.y < 110)
                {
                    y = 2;
                }
                else if (AppleRect.anchoredPosition.y > 109)
                {
                    y = 3;
                }

                if (x == 1 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(-40, 50);
                }

                else if (x == 2 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(0, 50);
                }

                else if (x == 3 && y == 1)
                {
                    AppleRect.anchoredPosition = new Vector2(40, 50);
                }
                if (x == 1 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(-40, 90);
                }

                else if (x == 2 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(0, 90);
                }

                else if (x == 3 && y == 2)
                {
                    AppleRect.anchoredPosition = new Vector2(40, 90);
                }
                if (x == 1 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(-40, 130);
                }

                else if (x == 2 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(0, 130);
                }

                else if (x == 3 && y == 3)
                {
                    AppleRect.anchoredPosition = new Vector2(40, 130);
                    
                }
            }
        }
    }

    public void Apple()
    {
        if (startTrack == true)
        {
            startTrack = false;
        }
        else
        {
            startTrack = true;
            hasClicked = true;
        }
    }
}

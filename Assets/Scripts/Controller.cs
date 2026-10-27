using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour
{
    public Image Wood;
    public Button WoodButton;

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
            Wood.rectTransform.anchoredPosition =
                new Vector2((float)(mouseX * 0.417)-50, (float)(mouseY * 0.417)-300);
        }

        if (hasClicked == true && startTrack == false)
        {
            if (Wood.rectTransform.anchoredPosition.y < -62)
            {


                if (Wood.rectTransform.anchoredPosition.x < 190)
                {
                    x = 1;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 230)
                {
                    x = 2;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 270)
                {
                    x = 3;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 310)
                {
                    x = 4;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 350)
                {
                    x = 5;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 390)
                {
                    x = 6;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 430)
                {
                    x = 7;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 470)
                {
                    x = 8;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 510)
                {
                    x = 9;
                }
                else if (Wood.rectTransform.anchoredPosition.x > 509)
                {
                    x = 10;
                }

                if (Wood.rectTransform.anchoredPosition.y < -200)
                {
                    y = 1;
                }
                else if (Wood.rectTransform.anchoredPosition.y < -160)
                {
                    y = 2;
                }
                else if (Wood.rectTransform.anchoredPosition.y < -120)
                {
                    y = 3;
                }
                else if (Wood.rectTransform.anchoredPosition.y > -119)
                {
                    y = 4;
                }

                if (x == 1 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(170, -220);
                }
                else if (x == 2 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(210, -220);
                }
                else if (x == 3 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(250, -220);
                }
                else if (x == 4 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(290, -220);
                }
                else if (x == 5 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(330, -220);
                }
                else if (x == 6 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(370, -220);
                }
                else if (x == 7 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(410, -220);
                }
                else if (x == 8 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(450, -220);
                }
                else if (x == 9 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(490, -220);
                }
                else if (x == 10 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(530, -220);
                }

                if (x == 1 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(170, -180);
                }
                else if (x == 2 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(210, -180);
                }
                else if (x == 3 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(250, -180);
                }
                else if (x == 4 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(290, -180);
                }
                else if (x == 5 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(330, -180);
                }
                else if (x == 6 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(370, -180);
                }
                else if (x == 7 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(410, -180);
                }
                else if (x == 8 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(450, -180);
                }
                else if (x == 9 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(490, -180);
                }
                else if (x == 10 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(530, -180);
                }

                if (x == 1 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(170, -140);
                }
                else if (x == 2 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(210, -140);
                }
                else if (x == 3 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(250, -140);
                }
                else if (x == 4 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(290, -140);
                }
                else if (x == 5 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(330, -140);
                }
                else if (x == 6 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(370, -140);
                }
                else if (x == 7 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(410, -140);
                }
                else if (x == 8 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(450, -140);
                }
                else if (x == 9 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(490, -140);
                }
                else if (x == 10 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(530, -140);
                }

                if (x == 1 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(170, -100);
                }
                else if (x == 2 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(210, -100);
                }
                else if (x == 3 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(250, -100);
                }
                else if (x == 4 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(290, -100);
                }
                else if (x == 5 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(330, -100);
                }
                else if (x == 6 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(370, -100);
                }
                else if (x == 7 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(410, -100);
                }
                else if (x == 8 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(450, -100);
                }
                else if (x == 9 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(490, -100);
                }
                else if (x == 10 && y == 4)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(530, -100);
                }
            }
            else if (Wood.rectTransform.anchoredPosition.y > -61)
            {
                if (Wood.rectTransform.anchoredPosition.x < 330)
                {
                    x = 1;
                }
                else if (Wood.rectTransform.anchoredPosition.x < 370)
                {
                    x = 2;
                }
                else if (Wood.rectTransform.anchoredPosition.x > 369)
                {
                    x = 3;
                }
                if (Wood.rectTransform.anchoredPosition.y < -5)
                {
                    y = 1;
                }
                else if (Wood.rectTransform.anchoredPosition.y < 35)
                {
                    y = 2;
                }
                else if (Wood.rectTransform.anchoredPosition.y > 34)
                {
                    y = 3;
                }

                if (x == 1 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(310, -25);
                }

                else if (x == 2 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(350, -25);
                }

                else if (x == 3 && y == 1)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(390, -25);
                }
                if (x == 1 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(310, 15);
                }

                else if (x == 2 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(350, 15);
                }

                else if (x == 3 && y == 2)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(390, 15);
                }
                if (x == 1 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(310, 55);
                }

                else if (x == 2 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(350, 55);
                }

                else if (x == 3 && y == 3)
                {
                    Wood.rectTransform.anchoredPosition = new Vector2(390, 55);
                    
                }
            }
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
    }
    public void WoodClick()
    {
        hasClicked = true;
        if (startTrack == true)
        {
            startTrack = false;
        }
        else
        {
            Debug.Log(x);
            Debug.Log(y);
            startTrack = true;   
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
public class Heart : MonoBehaviour
{
    public Image heart10;
    public Image heart9;
    public Image heart8;
    public Image heart7;
    public Image heart6;
    public Image heart5;
    public Image heart4;
    public Image heart3;
    public Image heart2;
    public Image heart1;
    public Sprite full;
    public Sprite half;
    public Sprite empty;
    public static int heartCount = 20;

    public int timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (heartCount == 20)
        {
            heart10.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart9.sprite = full;
            heart8.sprite = full;
            heart7.sprite = full;
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;
        }
        else if (heartCount == 19)
        {
            heart10.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart9.sprite = full;
            heart8.sprite = full;
            heart7.sprite = full;
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;
        }
        else if (heartCount == 18)
        {
            heart10.sprite = empty;
            heart9.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart8.sprite = full;
            heart7.sprite = full;
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;
        }
        else if (heartCount == 17)
        {
            heart10.sprite = empty;
            heart9.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart8.sprite = full;
            heart7.sprite = full;
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;
        }
        else if (heartCount == 16)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart7.sprite = full;
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;
        }
        else if (heartCount == 15)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart7.sprite = full;
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;
        }
        else if (heartCount == 14)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 13)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart6.sprite = full;
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 12)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 11)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart5.sprite = full;
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 10)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 9)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart4.sprite = full;
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 8)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 7)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart3.sprite = full;
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 6)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = empty;
            heart3.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 5)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = empty;
            heart3.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart2.sprite = full;
            heart1.sprite = full;    
        }
        else if (heartCount == 4)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = empty;
            heart3.sprite = empty;
            heart2.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
            heart1.sprite = full;    
        }
        else if (heartCount == 3)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = empty;
            heart3.sprite = empty;
            heart2.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
            heart1.sprite = full;    
        }
        else if (heartCount == 2)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = empty;
            heart3.sprite = empty;
            heart2.sprite = empty;
            heart1.sprite = full;
            heart10.rectTransform.sizeDelta = new Vector2(20, 20);
        }
        else if (heartCount == 1)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = empty;
            heart3.sprite = empty;
            heart2.sprite = empty;
            heart1.sprite = half;
            heart10.rectTransform.sizeDelta = new Vector2(10, 20);
        }
        else if (heartCount == 0)
        {
            heart10.sprite = empty;
            heart9.sprite = empty;
            heart8.sprite = empty;
            heart7.sprite = empty;
            heart6.sprite = empty;
            heart5.sprite = empty;
            heart4.sprite = empty;
            heart3.sprite = empty;
            heart2.sprite = empty;
            heart1.sprite = empty;    
        }
    }

    void FixedUpdate()
    {
        if (Hunger.hunger < 1)
        {
            timer += 1;
        }
        else
        {
            timer = 0;
        }

        if (timer >= 500)
        {
            heartCount -= 1;
            timer = 0;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
public class Hunger : MonoBehaviour
{
    public Image hunger1;
    public Image hunger2;
    public Image hunger3;
    public Image hunger4;
    public Image hunger5;
    public Image hunger6;
    public Image hunger7;
    public Image hunger8;
    public Image hunger9;
    public Image hunger10;
    public float hunger = 100000f;
    public float hungerRate = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hunger > 90000)
        {
            hunger1.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 80000)
        {
            hunger2.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 70000)
        {
            hunger3.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 60000)
        {
            hunger4.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 50000)
        {
            hunger5.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 40000)
        {
            hunger6.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 30000)
        {
            hunger7.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 20000)
        {
            hunger8.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 10000)
        {
            hunger9.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
        else if (hunger > 0)
        {
            hunger10.rectTransform.localScale = new Vector2((float)0.1, 1);
        }
    }

    void FixedUpdate()
    {
        hunger -= hungerRate;
    }
}

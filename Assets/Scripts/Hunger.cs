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
    public static float hunger = 100000f;
    public float hungerRate = 3f;

    public int remain = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hunger = 100000f;
        hungerRate = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (hunger > 100000)
        {
            hunger = 100000;
        }
        if (hunger > 90000)
        {
            remain = (int)(hunger % 10000);
            hunger1.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 80000)
        {
            remain = (int)(hunger % 10000);
            hunger2.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 70000)
        {
            remain = (int)(hunger % 10000);
            hunger3.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 60000)
        {
            remain = (int)(hunger % 10000);
            hunger4.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 50000)
        {
            remain = (int)(hunger % 10000);
            hunger5.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 40000)
        {
            remain = (int)(hunger % 10000);
            hunger6.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 30000)
        {
            remain = (int)(hunger % 10000);
            hunger7.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 20000)
        {
            remain = (int)(hunger % 10000);
            hunger8.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 10000)
        {
            remain = (int)(hunger % 10000);
            hunger9.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
        else if (hunger > 0)
        {
            remain = (int)(hunger % 10000);
            hunger10.rectTransform.localScale = new Vector2((float)remain / 10000, 1);
        }
    }

    void FixedUpdate()
    {
        if (PlayerMovement.isSprinting == true)
        {
            hunger -= hungerRate*3;
        }
        else
        {
            hunger -= hungerRate;
        }
    }
}

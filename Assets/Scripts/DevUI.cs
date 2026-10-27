using UnityEngine;
using UnityEngine.UI;

public class DevUI : MonoBehaviour
{
    public Image DevMenu;

    public Image Wood;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void DevButton()
    {
        if (DevMenu.enabled)
        {
            
            if (Wood.rectTransform.anchoredPosition.x > 0)
            {
                Debug.Log("WOOD");
                Wood.enabled = true;
            }
            else
            {
                Debug.Log("WOODNo");
                Wood.enabled = false;
            }
            DevMenu.enabled = false;
        }
        else{
            DevMenu.enabled = true;
            Wood.enabled = true;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class DevUI : MonoBehaviour
{
    public Image DevMenu;
    public Button AppleButton;
    public Image Wood;

    public Image Inv;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Inv.enabled)
        {
            AppleButton.image.enabled = true;
        }
    }

    public void DevButton()
    {
        if (DevMenu.enabled)
        {
            Wood.enabled = true;
        }
        else{
            DevMenu.enabled = true;
            Wood.enabled = true;
        }
    }
}

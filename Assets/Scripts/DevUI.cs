using UnityEngine;
using UnityEngine.UI;

public class DevUI : MonoBehaviour
{
    public Image DevMenu;
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
        DevMenu.enabled = false;
    }
}

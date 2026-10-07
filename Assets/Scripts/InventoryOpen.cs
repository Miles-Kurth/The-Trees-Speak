using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class InventoryOpen : MonoBehaviour
{
    public Image Inv;

    public Image Heart1;
    public Image Heart2;
    public Image Heart3;
    public Image Heart4;
    public Image Heart5;
    public Image Heart6;
    public Image Heart7;
    public Image Heart8;
    public Image Heart9;
    public Image Heart10;

    public Image Hunger1;
    public Image Hunger2;
    public Image Hunger3;
    public Image Hunger4;
    public Image Hunger5;
    public Image Hunger6;
    public Image Hunger7;
    public Image Hunger8;
    public Image Hunger9;
    public Image Hunger10;

    public Image Stamina;

    public Image Inventory1;
    public Image Inventory2;
    public Image Inventory3;
    public Image Inventory4;
    public Image Inventory5;
    public Image Inventory6;
    public Image Inventory7;
    public Image Inventory8;
    public Image Inventory9;
    public Image Inventory10;
    public Image Inventory11;
    public Image Inventory12;
    public Image Inventory13;
    public Image Inventory14;
    public Image Inventory15;
    public Image Inventory16;
    public Image Inventory17;
    public Image Inventory18;
    public Image Inventory19;
    public Image Inventory20;
    public Image Inventory21;
    public Image Inventory22;
    public Image Inventory23;
    public Image Inventory24;
    public Image Inventory25;
    public Image Inventory26;
    public Image Inventory27;
    public Image Inventory28;
    public Image Inventory29;
    public Image Inventory30;
    public Image Inventory31;
    public Image Inventory32;
    public Image Inventory33;
    public Image Inventory34;
    public Image Inventory35;
    public Image Inventory36;
    public Image Inventory37;
    public Image Inventory38;
    public Image Inventory39;
    public Image Inventory40;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Inv.enabled = false;
        Inventory11.enabled = false;
        Inventory12.enabled = false;
        Inventory13.enabled = false;
        Inventory14.enabled = false;
        Inventory15.enabled = false;
        Inventory16.enabled = false;
        Inventory17.enabled = false;
        Inventory18.enabled = false;
        Inventory19.enabled = false;
        Inventory20.enabled = false;
        Inventory21.enabled = false;
        Inventory22.enabled = false;
        Inventory23.enabled = false;
        Inventory24.enabled = false;
        Inventory25.enabled = false;
        Inventory26.enabled = false;
        Inventory27.enabled = false;
        Inventory28.enabled = false;
        Inventory29.enabled = false;
        Inventory30.enabled = false;
        Inventory31.enabled = false;
        Inventory32.enabled = false;
        Inventory33.enabled = false;
        Inventory34.enabled = false;
        Inventory35.enabled = false;
        Inventory36.enabled = false;
        Inventory37.enabled = false;
        Inventory38.enabled = false;
        Inventory39.enabled = false;
        Inventory40.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (Inventory11.enabled == false)
            {
                Heart1.enabled = false;
                Heart2.enabled = false;
                Heart3.enabled = false;
                Heart4.enabled = false;
                Heart5.enabled = false;
                Heart6.enabled = false;
                Heart7.enabled = false;
                Heart8.enabled = false;
                Heart9.enabled = false;
                Heart10.enabled = false;
                Hunger1.enabled = false;
                Hunger2.enabled = false;
                Hunger3.enabled = false;
                Hunger4.enabled = false;
                Hunger5.enabled = false;
                Hunger6.enabled = false;
                Hunger7.enabled = false;
                Hunger8.enabled = false;
                Hunger9.enabled = false;
                Hunger10.enabled = false;
                Stamina.enabled = false;
                Inventory11.enabled = true;
                Inventory12.enabled = true;
                Inventory13.enabled = true;
                Inventory14.enabled = true;
                Inventory15.enabled = true;
                Inventory16.enabled = true;
                Inventory17.enabled = true;
                Inventory18.enabled = true;
                Inventory19.enabled = true;
                Inventory20.enabled = true;
                Inventory21.enabled = true;
                Inventory22.enabled = true;
                Inventory23.enabled = true;
                Inventory24.enabled = true;
                Inventory25.enabled = true;
                Inventory26.enabled = true;
                Inventory27.enabled = true;
                Inventory28.enabled = true;
                Inventory29.enabled = true;
                Inventory30.enabled = true;
                Inventory31.enabled = true;
                Inventory32.enabled = true;
                Inventory33.enabled = true;
                Inventory34.enabled = true;
                Inventory35.enabled = true;
                Inventory36.enabled = true;
                Inventory37.enabled = true;
                Inventory38.enabled = true;
                Inventory39.enabled = true;
                Inventory40.enabled = true;

            }
            else
            {
                Inv.enabled = false;
                Heart1.enabled = true;
                Heart2.enabled = true;
                Heart3.enabled = true;
                Heart4.enabled = true;
                Heart5.enabled = true;
                Heart6.enabled = true;
                Heart7.enabled = true;
                Heart8.enabled = true;
                Heart9.enabled = true;
                Heart10.enabled = true;
                Hunger1.enabled = true;
                Hunger2.enabled = true;
                Hunger3.enabled = true;
                Hunger4.enabled = true;
                Hunger5.enabled = true;
                Hunger6.enabled = true;
                Hunger7.enabled = true;
                Hunger8.enabled = true;
                Hunger9.enabled = true;
                Hunger10.enabled = true;
                Stamina.enabled = true;
                Inventory11.enabled = false;
                Inventory12.enabled = false;
                Inventory13.enabled = false;
                Inventory14.enabled = false;
                Inventory15.enabled = false;
                Inventory16.enabled = false;
                Inventory17.enabled = false;
                Inventory18.enabled = false;
                Inventory19.enabled = false;
                Inventory20.enabled = false;
                Inventory21.enabled = false;
                Inventory22.enabled = false;
                Inventory23.enabled = false;
                Inventory24.enabled = false;
                Inventory25.enabled = false;
                Inventory26.enabled = false;
                Inventory27.enabled = false;
                Inventory28.enabled = false;
                Inventory29.enabled = false;
                Inventory30.enabled = false;
                Inventory31.enabled = false;
                Inventory32.enabled = false;
                Inventory33.enabled = false;
                Inventory34.enabled = false;
                Inventory35.enabled = false;
                Inventory36.enabled = false;
                Inventory37.enabled = false;
                Inventory38.enabled = false;
                Inventory39.enabled = false;
                Inventory40.enabled = false;
            }
        }
    }
}

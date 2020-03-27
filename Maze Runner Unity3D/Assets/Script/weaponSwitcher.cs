using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSwitcher : MonoBehaviour
{
    public int selectedWeapon;
    public int TotalFire;

    public playerMovementScript pmove;
    public Canvas Gun_UI;

    void Start()
    {
        SelectWeapon();
    }
    
    void Update()
    {
        int currentSelection = selectedWeapon;

        if(Input.GetButtonDown("Fire2"))
        {
            if (selectedWeapon >= transform.childCount - 1)
                selectedWeapon = 0;
            else
                selectedWeapon++;
        }

        //switching weapon
        if(currentSelection != selectedWeapon)
        {
            SelectWeapon();
        }

        //Speed controller
        if (selectedWeapon == 0)
        {
            pmove.speed = 1f;
            Gun_UI.enabled = false;
        }
        else
        {
            pmove.speed = 0.5f;
            Gun_UI.enabled = true;
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}

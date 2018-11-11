using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CraftPanel : MonoBehaviour {

    //Script for the Crafting panel. used to access weapon prefab and craft new weapon. 
    public WeaponInventory inventory;
    public TMP_InputField nameLabel;
    public TMP_InputField descLabel;
    public Weapon weaponPrefab;
    public Manager ThisManager;

    //Craft function
    public void Craft()
    {
        //When called creates a weapon from the prefab and names it based on what is typed uin the name and desc then adds it. 
        Weapon newWeapon = Instantiate<Weapon>(weaponPrefab);
        newWeapon.name = nameLabel.text;
        newWeapon.description = descLabel.text;
        inventory.AddWeapon(newWeapon);

        //Resets the name and desc text back to nothing.
        nameLabel.text = "";
        descLabel.text = "";

        //Sets the crafting to false and also Sets the weapons level based on what was used to make weapon. 
        ThisManager.Crafting = false;
        if (ThisManager.WoodBladeHead || ThisManager.WoodAxeHead || ThisManager.WoodHammerHead == true)
        {
            newWeapon.level = 1;
        }
        if (ThisManager.MetalBladeHead || ThisManager.MetalAxeHead || ThisManager.MetalHammerHead == true)
        {
            newWeapon.level = 3;
        }
        if (ThisManager.MithralBladeHead || ThisManager.MithralAxeHead || ThisManager.MithralHammerHead == true)
        {
            newWeapon.level = 5;
        }

        //Calls the clear all bools after weapon making and level assigning is complete. 
        ThisManager.Clearallbools();
    }
}
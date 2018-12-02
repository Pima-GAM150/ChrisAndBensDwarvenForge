using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CraftPanel : MonoBehaviour {

    public Manager ThisManager; // Manager referanced.
    public Transform WeaponPile;

    //Script for the Crafting panel. used to access weapon prefab and craft new weapon. 
    public WeaponInventory inventory;
    public TMP_InputField nameLabel;
    public TMP_InputField descLabel;
    public Weapon weaponPrefab;

    //Craft function
    public void CraftWeapon()
    {
        //When called creates a weapon from the prefab and names it based on what is typed uin the name and desc then adds it. 
        Weapon newWeapon = Instantiate<Weapon>(weaponPrefab);
        newWeapon.name = nameLabel.text;
        newWeapon.description = descLabel.text;
        newWeapon.head = ThisManager.craftedHead;
        newWeapon.hilt = ThisManager.craftedHilt;
        newWeapon.level = ThisManager.craftedHead.level + ThisManager.craftedHilt.level;
        inventory.AddWeapon(newWeapon);
        newWeapon.transform.position = WeaponPile.position;
        newWeapon.transform.Rotate(0f, 0f, Random.Range(0f, 360f));
        newWeapon.RegenerateAppearance();

        //Resets the name and desc text back to nothing and clears the crafting inventory
        nameLabel.text = "";
        descLabel.text = "";
        ThisManager.craftedHead = null;
        ThisManager.craftedHilt = null;

        ThisManager.CloseMenus();
    }
}
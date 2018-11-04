using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CraftPanel : MonoBehaviour {

    public WeaponInventory inventory;

    public TMP_InputField nameLabel;
    public TMP_InputField descLabel;
    public Weapon weaponPrefab;
    public Manager ThisManager;
    

    public void Craft()
    {
        Weapon newWeapon = Instantiate<Weapon>(weaponPrefab);
        newWeapon.name = nameLabel.text;
        newWeapon.description = descLabel.text;

        inventory.AddWeapon(newWeapon);
        nameLabel.text = "";
        descLabel.text = "";
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
        ThisManager.Clearallbools();

    }
   
        



}

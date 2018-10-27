using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CraftPanel : MonoBehaviour {

    public WeaponInventory inventory;

    public TMP_InputField nameLabel;
    public TMP_InputField descLabel;
    public Weapon weaponPrefab;
    

    public void Craft()
    {
        Weapon newWeapon = Instantiate<Weapon>(weaponPrefab);
        newWeapon.name = nameLabel.text;
        newWeapon.description = descLabel.text;

        inventory.AddWeapon(newWeapon);
    }
}

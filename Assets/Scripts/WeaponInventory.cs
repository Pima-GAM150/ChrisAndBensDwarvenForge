using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour {

    public List<Weapon> weapons = new List<Weapon>();

    public void AddWeapon( Weapon newWeapon )
    {
        weapons.Add(newWeapon);
    }
}

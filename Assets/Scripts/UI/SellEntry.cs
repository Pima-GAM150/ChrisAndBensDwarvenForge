using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellEntry : MonoBehaviour {

    public Text weaponNameLabel;
    public Text weaponValue;
    public Button sellButton;

    public Weapon weaponToSell;

    public void Initialize( Weapon weapon )
    {
        weaponNameLabel.text = weapon.name;
        weaponValue.text = weapon.level.ToString();
        weaponToSell = weapon;

        print("Initializing entry with weapon " + weapon.name + " and text " + weaponNameLabel.text);
    }
}

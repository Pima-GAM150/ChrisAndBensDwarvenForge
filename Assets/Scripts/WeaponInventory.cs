using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour {

    public List<Weapon> weapons = new List<Weapon>(); // keeps track of all the weapons the player has crafted during the game
    public Weapon weaponPrefab; // a reference to the weapon GameObject to create copies of when crafting or loading is completed

    public void AddWeapon( Weapon newWeapon )
    {
        weapons.Add(newWeapon); // adds a weapon to the list we keep of crafted weapons
    }

    // method that takes a "save slot" name and saves data by that name
    public void SaveAll( string saveName ) {
        List<string> saveData = new List<string>(); // a list to hold the weapon data converted into the form of strings (json) 
        for( int index = 0; index < weapons.Count; index++ ) // go through each weapon saved in our records
        {
            saveData.Add( weapons[index].Save() ); // tells the weapon to Save, which returns a json version of its data, then adds that json to the list to save
        }

        // create a data object that holds an array of jsons (one for each weapon).  In this form, the list can itself be converted to json.
        SerializableInventory saveableInventory = new SerializableInventory
        {
            weaponJsons = saveData.ToArray()
        };

        string json = JsonUtility.ToJson( saveableInventory ); // convert the SerializableInventory object to a string (json)

        print( "Saving " + json ); // report the data being saved for easy reference
        PlayerPrefs.SetString( saveName, json ); // stores it in PlayerPrefs, but it could easily be stored as a text file on disk
    }

    // this method is almost the exact reverse of the SaveAll method
    public void LoadAll( string saveName )
    {
        string json = PlayerPrefs.GetString( saveName ); // fetches the string json that was saved under this save name

        print( "Loading " + json ); // reports what it's loading for easy reference

        SerializableInventory loadedInventory = JsonUtility.FromJson<SerializableInventory>(json); // convert back from string to SerializableInventory

        // go through each string (json) in the SerializableInventory list, create a new weapon GO for it from a prefab, then tell the weapon to load itself based on the json
        for( int index = 0; index < loadedInventory.weaponJsons.Length; index++ )
        {
            Weapon newWeapon = Instantiate<Weapon>(weaponPrefab);
            newWeapon.Load(loadedInventory.weaponJsons[index]);
            AddWeapon( newWeapon ); // add the instantiated and loaded weapon back into the crafted list
        }
    }
}

public class SerializableInventory
{
    public string[] weaponJsons;
}
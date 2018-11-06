using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public int level;
    public string description;

    // the weapon should know how to save itself to json, so whoever wants to save it can just get a saveable version of its data
    public string Save()
    {
        // create an object that can be easily converted to json and copy our relevant data into it
        // you will want to expand this list if there's anything else you want to save about a weapon
        SerializableWeapon weaponData = new SerializableWeapon
        {
            level = this.level,
            name = this.name,
            description = this.description
        };
        string json = JsonUtility.ToJson( weaponData ); // convert it to json
        return json; // return the saveable data to whoever wants it
    }

    public void Load( string json )
    {
        // unpack the serializable version of a weapon from the provided json string
        SerializableWeapon weaponData = JsonUtility.FromJson<SerializableWeapon>(json);

        // copy its data into this weapon's fields, overwriting what's there
        this.level = weaponData.level;
        this.description = weaponData.description;
        this.name = weaponData.name;


    }
}

// a class that contains all data we might want to save about an object
public class SerializableWeapon
{
    public int level;
    public string name;
    public string description;
}

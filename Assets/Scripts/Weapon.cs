using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public int level;
    public string description;

    public string Save()
    {
        SerializableWeapon weaponData = new SerializableWeapon
        {
            level = this.level,
            name = this.name,
            description = this.description
        };
        string json = JsonUtility.ToJson( weaponData );
        return json;
    }

    void Load( string json )
    {
        SerializableWeapon weaponData = JsonUtility.FromJson<SerializableWeapon>(json);
        this.level = weaponData.level;
        this.description = weaponData.description;
    }
}

public class SerializableWeapon
{
    public int level;
    public string name;
    public string description;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public WeaponComponent hilt { get; set; }
    public WeaponComponent head { get; set; }
    public int level { get; set; }
    public string description { get; set; }

    public SpriteRenderer headRenderer;
    public SpriteRenderer hiltRenderer;

    // the weapon should know how to save itself to json, so whoever wants to save it can just get a saveable version of its data
    public string Save()
    {
        // create an object that can be easily converted to json and copy our relevant data into it
        // you will want to expand this list if there's anything else you want to save about a weapon
        SerializableWeapon weaponData = new SerializableWeapon
        {
            level = this.level,
            name = this.name,
            description = this.description,
            headIndex = Manager.singleton.IndexOfWeaponHead( head ),
            hiltIndex = Manager.singleton.IndexOfWeaponHilt( hilt )
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
        this.head = Manager.singleton.WeaponHeadFromIndex( weaponData.headIndex );
        this.hilt = Manager.singleton.WeaponHiltFromIndex( weaponData.hiltIndex );

        RegenerateAppearance();
    }

    public void RegenerateAppearance() {
        headRenderer.sprite = head.appearance;
        hiltRenderer.sprite = hilt.appearance;
    }
}

// a class that contains all data we might want to save about an object
public class SerializableWeapon
{
    public int level;
    public int headIndex;
    public int hiltIndex;
    public string name;
    public string description;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour {

    public List<Weapon> weapons = new List<Weapon>();
    public Weapon weaponPrefab;

    public void AddWeapon( Weapon newWeapon )
    {
        weapons.Add(newWeapon);
    }

    public void SaveAll() {
        List<string> saveData = new List<string>();
        for( int index = 0; index < weapons.Count; index++ )
        {
            saveData.Add( weapons[index].Save() );
        }

        SerializableInventory jsonEverything = new SerializableInventory
        {
            weaponJsons = saveData.ToArray()
        };

        string allData = JsonUtility.ToJson(jsonEverything);
    }

    public void LoadAll( string allData )
    {
        SerializableInventory loadedInventory = JsonUtility.FromJson<SerializableInventory>(allData);

        for( int index = 0; index < loadedInventory.weaponJsons.Length; index++ )
        {
            Weapon newWeapon = Instantiate<Weapon>(weaponPrefab);
            newWeapon.Load(loadedInventory.weaponJsons[index]);
        }
    }
}

public class SerializableInventory
{
    public string[] weaponJsons;
}
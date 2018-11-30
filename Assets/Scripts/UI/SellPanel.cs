using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellPanel : MonoBehaviour {

    public SellEntry entryPrefab;

    public RectTransform scrollContent;

    List<SellEntry> entries = new List<SellEntry>();

    private void OnEnable()
    {
        Refresh();
    }

    public void Sell( Weapon weapon )
    {
        Manager.singleton.craftPanel.inventory.RemoveWeapon(weapon);

        Refresh();

        Manager.singleton.craftPanel.inventory.SaveAll("Save Game Name");
    }

    public void Refresh()
    {
        foreach( SellEntry entry in entries )
        {
            Destroy(entry.gameObject);
        }

        entries = new List<SellEntry>();

        foreach( Weapon weapon in Manager.singleton.craftPanel.inventory.weapons )
        {
            print("Adding entry for new weapon named " + weapon.name);
            SellEntry newEntry = Instantiate<SellEntry>(entryPrefab);
            newEntry.transform.SetParent(scrollContent, false);
            newEntry.Initialize(weapon);
            newEntry.sellButton.onClick.AddListener( () => Sell(weapon) );

            entries.Add(newEntry);
        }
    }
}

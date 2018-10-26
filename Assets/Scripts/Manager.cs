using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public bool Crafting;
    public GameObject InventoryPanel;

    public void Update(){
        if(Crafting == true){
            InventoryPanel.SetActive(true);
        }
        else{
            InventoryPanel.SetActive(false);
        }
    }
}

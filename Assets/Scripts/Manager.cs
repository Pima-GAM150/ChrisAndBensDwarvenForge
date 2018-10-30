using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public bool Crafting;
	public bool MWood;
	public bool MMetal;
	public bool MMithral;
	public bool Hilt;
	public bool Blade;
    public GameObject InventoryPanel;
    public GameObject HiltPanel;
    public GameObject WeaponPanel;

    public void Update(){
        if(Crafting == true){
            InventoryPanel.SetActive(true);
        }
        else{
            InventoryPanel.SetActive(false);
        }
        if(Hilt == true){
        	HiltPanel.SetActive(true);
        }
        else{
        	HiltPanel.SetActive(false);
        }
        if( Blade == true){
        	WeaponPanel.SetActive(true);
        }
        else{
        	WeaponPanel.SetActive(false);
        }
    }
}

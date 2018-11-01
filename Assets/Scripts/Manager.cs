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
	public bool WoodBladeHead;
	public bool MetalBladeHead;
	public bool MithralBladeHead;
	public bool WoodAxeHead;
	public bool MetalAxeHead;
	public bool MithralAxeHead;
	public bool WoodHammerHead;
	public bool MetalHammerHead;
	public bool MithralHammerHead;
	public bool WoodHilt;
	public bool Headslot;
	public bool Hiltslot;
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
        if(Hilt == true && Hiltslot == false){
        	HiltPanel.SetActive(true);
        }
        else{
        	HiltPanel.SetActive(false);
        }
        if( Blade == true && Headslot == false){
        	WeaponPanel.SetActive(true);
        }
        else{
        	WeaponPanel.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public bool Crafting;
	public bool QuitMenu;
    
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
    public GameObject QuitSaveLoad;
    public GameObject MaterialIcon;
    public GameObject HiltIcon;
    public GameObject WeaponIcon;

    public GameObject WoodBlade;
    public GameObject MetalBlade;
    public GameObject MithralBlade;
    public GameObject WoodAxe;
    public GameObject MetalAxe;
    public GameObject MithralAxe;
    public GameObject WoodHammer;
    public GameObject MetalHammer;
    public GameObject MithralHammer;

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
        if(QuitMenu == true){
        	QuitSaveLoad.SetActive(true);
        }
        else{
        	QuitSaveLoad.SetActive(false);
        }
        if(Hiltslot == true){
        	HiltIcon.SetActive(true);
        }
        else {
        	HiltIcon.SetActive(false);
        }
        if(Headslot == true){
        	WeaponIcon.SetActive(true);
        }
        else {
        	WeaponIcon.SetActive(false);
        }
        if(MWood || MMetal || MMithral == true){
        	MaterialIcon.SetActive(true);
        }
        else{
        	MaterialIcon.SetActive(false);
        }
        if(WoodBladeHead == true){
        	WoodBlade.SetActive(true);
        }
        else{
        	WoodBlade.SetActive(false);
        }
        if(MetalBladeHead == true){
        	MetalBlade.SetActive(true);
        }
        else{
        	MetalBlade.SetActive(false);
        }
        if(MithralBladeHead == true){
        	MithralBlade.SetActive(true);
        }
        else{
        	MithralBlade.SetActive(false);
        }
        if(WoodAxeHead == true){
        	WoodAxe.SetActive(true);
        }
        else{
        	WoodAxe.SetActive(false);
        }
        if(MetalAxeHead == true){
        	MetalAxe.SetActive(true);
        }
        else{
        	MetalAxe.SetActive(false);
        }
        if(MithralAxeHead == true){
        	MithralAxe.SetActive(true);
        }
        else{
        	MithralAxe.SetActive(false);
        }
        if(WoodHammerHead == true){
        	WoodHammer.SetActive(true);
        }
        else{
        	WoodHammer.SetActive(false);
        }
        if(MetalHammerHead == true){
        	MetalHammer.SetActive(true);
        }
        else{
        	MetalHammer.SetActive(false);
        }
        if(MithralHammerHead == true){
        	MithralHammer.SetActive(true);
        }
        else{
        	MithralHammer.SetActive(false);
        }


    }

    public void Clearallbools()
    {
        Headslot = false;
        Hiltslot = false;
        WoodBladeHead = false;
        MetalBladeHead = false;
        MithralBladeHead = false;
        WoodAxeHead = false;
        MetalAxeHead = false;
        MithralAxeHead = false;
        WoodHammerHead = false;
        MetalHammerHead = false;
        MithralHammerHead = false;
        MWood = false;
        MMetal = false;
        MMithral = false;
    }
}

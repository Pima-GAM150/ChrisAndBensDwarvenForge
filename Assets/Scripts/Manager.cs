using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	//Script to Manage the bool and control the crafting system. 

	//whether menus are true or not. 
	public bool Crafting;
	public bool QuitMenu;

    public Alloy carryingAlloy
    {
        get { return _carryingAlloy; }
        set
        {
            _carryingAlloy = value;
            MaterialIcon.alloyAppearance.sprite = _carryingAlloy.appearance;
        }
    }
    Alloy _carryingAlloy;
    
    //Whether materials are true or not.
	public bool MWood;
	public bool MMetal;
	public bool MMithral;

	//Display of materials.
	public GameObject MWoodDisplay;
	public GameObject MMetalDisplay;
	public GameObject MMithralDisplay;

	//Whether hilt or blade are true or not.
	public bool Hilt;
	public bool Blade;

	//Whether heads are true or not.
	public bool WoodBladeHead;
	public bool MetalBladeHead;
	public bool MithralBladeHead;
	public bool WoodAxeHead;
	public bool MetalAxeHead;
	public bool MithralAxeHead;
	public bool WoodHammerHead;
	public bool MetalHammerHead;
	public bool MithralHammerHead;

	//Whether hilt or slots are true or not.
	public bool WoodHilt;
	public bool Headslot;
	public bool Hiltslot;

	//Panels and Icons
    public GameObject InventoryPanel;
    public GameObject HiltPanel;
    public GameObject WeaponPanel;
    public GameObject QuitSaveLoad;
    public Icon MaterialIcon;
    public GameObject HiltIcon;
    public GameObject WeaponIcon;

    //Display of Object for UI
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

    	//If Crafting is true, turn on the inventory panel, or vice versa.
        if(Crafting == true){
            InventoryPanel.SetActive(true); 
        }
        else{
            InventoryPanel.SetActive(false);
        }

        //If hilt is true and slot is false then hilt panel is turned on or vice versa. 
        if(Hilt == true && Hiltslot == false){
        	HiltPanel.SetActive(true);
        }
        else{
        	HiltPanel.SetActive(false);
        }

        //if blade is true and headslot is false then the weapon panel turns on or vice versa. 
        if( Blade == true && Headslot == false){
        	WeaponPanel.SetActive(true);
        }
        else{
        	WeaponPanel.SetActive(false);
        }

        //if quitmenu is true then turn on quitsaveload panel. 
        if(QuitMenu == true){
        	QuitSaveLoad.SetActive(true);
        }
        else{
        	QuitSaveLoad.SetActive(false);
        }

        //if hiltslot is true than hilt icon is turned on or vice versa.
        if(Hiltslot == true){
        	HiltIcon.SetActive(true);
        }
        else {
        	HiltIcon.SetActive(false);
        }

        //if headslot is true then weapon icon is turned on or vice versa.
        if(Headslot == true){
        	WeaponIcon.SetActive(true);
        }
        else {
        	WeaponIcon.SetActive(false);
        }

        //if wood blade head is true then wood blade is displayed in icon box.
        if(WoodBladeHead == true){
        	WoodBlade.SetActive(true);
        }
        else{
        	WoodBlade.SetActive(false);
        }

        //if metal blade head is true then metal blade is disploayed in icon box.
        if(MetalBladeHead == true){
        	MetalBlade.SetActive(true);
        }
        else{
        	MetalBlade.SetActive(false);
        }

        //if mithral blade head is true then mithral blade is disploayed in icon box.
        if(MithralBladeHead == true){
        	MithralBlade.SetActive(true);
        }
        else{
        	MithralBlade.SetActive(false);
        }

        //if Wood axe head is true then wood axe is disploayed in icon box.
        if(WoodAxeHead == true){
        	WoodAxe.SetActive(true);
        }
        else{
        	WoodAxe.SetActive(false);
        }

        //if metal axe head is true then metal axe is disploayed in icon box.
        if(MetalAxeHead == true){
        	MetalAxe.SetActive(true);
        }
        else{
        	MetalAxe.SetActive(false);
        }

        //if mithral axe head is true then mithral axe is disploayed in icon box.
        if(MithralAxeHead == true){
        	MithralAxe.SetActive(true);
        }
        else{
        	MithralAxe.SetActive(false);
        }

        //if Wood hammer head is true then wood hammer is disploayed in icon box.
        if(WoodHammerHead == true){
        	WoodHammer.SetActive(true);
        }
        else{
        	WoodHammer.SetActive(false);
        }

        //if metal hammer head is true then metal hammer is disploayed in icon box.
        if(MetalHammerHead == true){
        	MetalHammer.SetActive(true);
        }
        else{
        	MetalHammer.SetActive(false);
        }

        //if mithral hammer head is true then mithral hammer is disploayed in icon box.
        if(MithralHammerHead == true){
        	MithralHammer.SetActive(true);
        }
        else{
        	MithralHammer.SetActive(false);
        }
    }

    //Function to Clear all the materials, heads, and slots. 
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

    public void OpenBladeMaker()
    {

    }

    public void OpenHiltMaker()
    {

    }

    public void OpenPauseMenu()
    {
        
    }
}
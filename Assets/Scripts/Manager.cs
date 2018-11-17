using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	//Script to Manage the bool and control the crafting system.

    // Singleton
    public static Manager singleton;

    // Prefabs of all the game data
    public List<Alloy> allAlloys;
    public List<Variety> allWeaponVarieties;
    public List<WeaponComponent> allWeaponHeads;
    public List<WeaponComponent> allWeaponHilts;

    //Panels and Icons
    public GameObject InventoryPanel;
    public GameObject HiltPanel;
    public GameObject WeaponPanel;
    public GameObject CraftPanel;
    public GameObject QuitSaveLoad;
    public Icon MaterialIcon;
    public Icon HiltIcon;
    public Icon WeaponIcon;

    // Properties for getting and setting things you've picked up or crafted during the game
    public Alloy carryingAlloy
    {
        get { return _carryingAlloy; }
        set
        {
            _carryingAlloy = value;
<<<<<<< HEAD
            if (_carryingAlloy == null)
            {
                MaterialIcon.IconAppearance.sprite = null;
            }
            else
            {
                MaterialIcon.IconAppearance.sprite = _carryingAlloy.appearance;
            }
        }
    }
    Alloy _carryingAlloy;

    public Handle carryingHandle{
    	get { return _carryingHandle; }
    	set {
    		_carryingHandle = value;
    		if (_carryingHandle == null){
    			HiltIcon.IconAppearance.sprite = null;
    		}
    		else{
    			HiltIcon.IconAppearance.sprite = _carryingHandle.appearance;
    		}

    	}
    }
    Handle _carryingHandle;
    
    //Whether materials are true or not.
	public bool MWood;
	public bool MMetal;
	public bool MMithral;

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
    public Icon HiltIcon;
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
        //if(Hiltslot == true){
       // 	HiltIcon.SetActive(true);
      //  }
      //  else {
      //  	HiltIcon.SetActive(false);
      //  }

        //if headslot is true then weapon icon is turned on or vice versa.
        if(Headslot == true){
        	WeaponIcon.SetActive(true);
        }
        else {
        	WeaponIcon.SetActive(false);
=======
            if (_carryingAlloy == null) MaterialIcon.appearance.sprite = null;
            else MaterialIcon.appearance.sprite = _carryingAlloy.appearance;
        }
    }
    Alloy _carryingAlloy;

    public WeaponComponent craftedHead
    {
        get { return _craftedHead; }
        set
        {
            _craftedHead = value;
            if (_craftedHead == null) WeaponIcon.appearance.sprite = null;
            else WeaponIcon.appearance.sprite = _craftedHead.appearance;
>>>>>>> CraftingAdvice
        }
    }
    WeaponComponent _craftedHead;

    public WeaponComponent craftedHilt
    {
        get { return _craftedHilt; }
        set
        {
            _craftedHilt = value;
            if (_craftedHilt == null) HiltIcon.appearance.sprite = null;
            else HiltIcon.appearance.sprite = _craftedHilt.appearance;
        }
    }
    WeaponComponent _craftedHilt;

    // Singleton to make this manager easy to access
    void Awake() {
        singleton = this;
    }

    // Fetching data by their index in a fixed array or vice-versa
    public int IndexOfVariety( Variety variety ) { return allWeaponVarieties.IndexOf( variety ); }
    public Variety VarietyFromIndex( int index ) { return allWeaponVarieties[index]; }

    public int IndexOfAlloy( Alloy alloy ) { return allAlloys.IndexOf( alloy ); }
    public Alloy AlloyFromIndex( int index ) { return allAlloys[index]; }

    public int IndexOfWeaponHead( WeaponComponent head ) { return allWeaponHeads.IndexOf( head ); }
    public WeaponComponent WeaponHeadFromIndex( int index ) { return allWeaponHeads[index]; }

    public int IndexOfWeaponHilt( WeaponComponent hilt ) { return allWeaponHilts.IndexOf( hilt ); }
    public WeaponComponent WeaponHiltFromIndex( int index ) { return allWeaponHilts[index]; }

    // Turning on and off UI menus
    public void ToggleInventoryPanel( bool state ) { InventoryPanel.SetActive( state ); }
    public void ToggleWeaponPanel( bool state ) { WeaponPanel.SetActive( state ); }
    public void ToggleCraftPanel( bool state ) { CraftPanel.SetActive( state ); }
    public void ToggleHiltMaker( bool state ) { HiltPanel.SetActive( state ); }
    public void TogglePauseMenu( bool state ) { QuitSaveLoad.SetActive( state ); }

    public void CloseMenus() {
        ToggleHiltMaker( false );
        ToggleWeaponPanel( false );
        ToggleCraftPanel( false );
    }

    // Crafting
    public void CraftHead( Variety weaponType ) {
        if( craftedHead == null ) {
            craftedHead = LocateWeaponComponent( allWeaponHeads, carryingAlloy, weaponType );
            carryingAlloy = null;
            CloseMenus();
        }
    }

    public void CraftHilt() {
        if( craftedHilt == null ) {
            craftedHilt = LocateWeaponComponent( allWeaponHilts, carryingAlloy, null );
            carryingAlloy = null;
            CloseMenus();
        }
    }

    // Finding the right WeaponComponent from a given list by alloy and variety
    WeaponComponent LocateWeaponComponent( List<WeaponComponent> listToSearch, Alloy alloyToMatch, Variety weaponType ) {
        foreach( WeaponComponent candidate in listToSearch ) {

<<<<<<< HEAD
    public void HiltMaker(){
    	
    	HiltPanel.SetActive(true);
    	
	}
=======
            // if the component in the list either matches with the alloy and variety we're searching for, or if the alloy / variety is null (i.e. "any"), then it qualifies
            if( candidate.alloy == alloyToMatch && candidate.variety == weaponType ) {
                return candidate;
            }
        }

        return null;
    }
>>>>>>> CraftingAdvice

    // convenience property
    public bool anyMenuOpen { get { return InventoryPanel.activeSelf || HiltPanel.activeSelf || WeaponPanel.activeSelf; }}
}
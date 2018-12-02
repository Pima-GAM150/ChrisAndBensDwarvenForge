using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	//Script to Manage the bool and control the crafting system.

	public AudioSource ButtonClick;
	public Animator animator;
	public int TotalGold;

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
    public CraftPanel craftPanel;
    public SellPanel sellPanel;
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
    public void ToggleCraftPanel( bool state ) { craftPanel.gameObject.SetActive( state ); }
    public void ToggleHiltMaker( bool state ) { HiltPanel.SetActive( state ); }
    public void TogglePauseMenu( bool state ) { QuitSaveLoad.SetActive( state ); }

    public void CloseMenus() {
    	ButtonClick.Play(0);
    	animator.SetBool("SmithingTime",false);
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
        else{
        	CloseMenus();
        }
    }

    public void CraftHilt() {
        if( craftedHilt == null ) {
            craftedHilt = LocateWeaponComponent( allWeaponHilts, carryingAlloy, null );
            carryingAlloy = null;
            CloseMenus();
        }
        else{
        	CloseMenus();
        }
    }

    // Finding the right WeaponComponent from a given list by alloy and variety
    WeaponComponent LocateWeaponComponent( List<WeaponComponent> listToSearch, Alloy alloyToMatch, Variety weaponType ) {
        foreach( WeaponComponent candidate in listToSearch ) {

            // if the component in the list either matches with the alloy and variety we're searching for, or if the alloy / variety is null (i.e. "any"), then it qualifies
            if( candidate.alloy == alloyToMatch && candidate.variety == weaponType ) {
                return candidate;
            }
        }

        return null;
    }

    // convenience property
    public bool anyMenuOpen { get { return InventoryPanel.activeSelf || HiltPanel.activeSelf || WeaponPanel.activeSelf || QuitSaveLoad.activeSelf; }}
}
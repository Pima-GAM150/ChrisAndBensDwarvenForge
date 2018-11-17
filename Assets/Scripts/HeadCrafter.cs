using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCrafter : MonoBehaviour {
	//Script is for creating the weapon heads and hilt. 

	public Manager ThisManager; // Manager referanced.
	public Handle HandleMade;

	//function to create an axe head depending on the material. 
	public void CreateAxeHead(){
		if(ThisManager.Headslot == false){

			//if wood.
			if(ThisManager.MWood == true){
				ThisManager.WoodAxeHead = true;
				ThisManager.MWood = false;
				ThisManager.Headslot = true;
			}
			//if metal.
			if(ThisManager.MMetal == true){
				ThisManager.MetalAxeHead = true;
				ThisManager.MMetal = false;
				ThisManager.Headslot = true;
			}
			//if mithral.
			if(ThisManager.MMithral == true){
				ThisManager.MithralAxeHead = true;
				ThisManager.MMithral = false;
				ThisManager.Headslot = true;
			}
		}
		else{}

		//function to create a blade head depending on material.
	}
	public void CreateBladeHead(){
		if(ThisManager.Headslot == false){

			//if wood.
			if(ThisManager.MWood == true){
				ThisManager.WoodBladeHead = true;
				ThisManager.MWood = false;
				ThisManager.Headslot = true;
			}
			//if metal.
			if(ThisManager.MMetal == true){
				ThisManager.MetalBladeHead = true;
				ThisManager.MMetal = false;
				ThisManager.Headslot = true;
			}
			//if mithral.
			if(ThisManager.MMithral == true){
				ThisManager.MithralBladeHead = true;
				ThisManager.MMithral = false;
				ThisManager.Headslot = true;
		}
	}
	else{}
}
		//function to create a hammer head depending on material.
	public void CreateHammerHead(){
		if(ThisManager.Headslot == false){

			//if wood.
			if(ThisManager.MWood == true){
				ThisManager.WoodHammerHead = true;
				ThisManager.MWood = false;
				ThisManager.Headslot = true;
			}
			//if metal.
			if(ThisManager.MMetal == true){
				ThisManager.MetalHammerHead = true;
				ThisManager.MMetal = false;
				ThisManager.Headslot = true;
			}
			//if mithral.
			if(ThisManager.MMithral == true){
				ThisManager.MithralHammerHead = true;
				ThisManager.MMithral = false;
				ThisManager.Headslot = true;
		}
	}
	else{}
}

		//Function to create hilt with wood. 
	public void CreateHilt(){
        ThisManager.carryingAlloy = null;
        ThisManager.carryingHandle = HandleMade;
		ThisManager.HiltPanel.SetActive(false);
	}
}

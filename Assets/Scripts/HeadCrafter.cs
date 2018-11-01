using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCrafter : MonoBehaviour {

	public Manager ThisManager;

	public void CreateAxeHead(){
		if(ThisManager.Headslot == false){
			if(ThisManager.MWood == true){
				ThisManager.WoodAxeHead = true;
				ThisManager.MWood = false;
				ThisManager.Headslot = true;
			}
			if(ThisManager.MMetal == true){
				ThisManager.MetalAxeHead = true;
				ThisManager.MMetal = false;
				ThisManager.Headslot = true;
			}
			if(ThisManager.MMithral == true){
				ThisManager.MithralAxeHead = true;
				ThisManager.MMithral = false;
				ThisManager.Headslot = true;
			}
		}
		else{}

	}
	public void CreateBladeHead(){
		if(ThisManager.Headslot == false){
			if(ThisManager.MWood == true){
				ThisManager.WoodBladeHead = true;
				ThisManager.MWood = false;
				ThisManager.Headslot = true;
			}
			if(ThisManager.MMetal == true){
				ThisManager.MetalBladeHead = true;
				ThisManager.MMetal = false;
				ThisManager.Headslot = true;
			}
			if(ThisManager.MMithral == true){
				ThisManager.MithralBladeHead = true;
				ThisManager.MMithral = false;
				ThisManager.Headslot = true;
		}
	}
	else{}
}
	public void CreateHammerHead(){
		if(ThisManager.Headslot == false){
			if(ThisManager.MWood == true){
				ThisManager.WoodHammerHead = true;
				ThisManager.MWood = false;
				ThisManager.Headslot = true;
			}
			if(ThisManager.MMetal == true){
				ThisManager.MetalHammerHead = true;
				ThisManager.MMetal = false;
				ThisManager.Headslot = true;
			}
			if(ThisManager.MMithral == true){
				ThisManager.MithralHammerHead = true;
				ThisManager.MMithral = false;
				ThisManager.Headslot = true;
		}
	}
	else{}
}
	public void CreateHilt(){
		ThisManager.MWood = false;
		ThisManager.WoodHilt = true;
		ThisManager.Hiltslot = true;
	}
}

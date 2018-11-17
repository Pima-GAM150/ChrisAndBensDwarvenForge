using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    //Script for controlling the player. 

    //Player Components to use and call on. Transform, collider, and ridgidbody. 
    public Transform Player;
    public BoxCollider2D Mycollidor;
    public Rigidbody2D RigidBodyChar;

    //floats for buttons and rotations as well as movement speed. 
    public float speed;
    private float buttonX;
    private float buttonY;
    private float Yrotate = 0f;
    private float Xrotate = 0f;

    //Manager variable to access the manager in the scene.
    public Manager ThisManager;
    public WeaponInventory ThisInventory;

    //Animator for the Character controller to access and use. 
    public Animator animator;

    // Update is called once per frame
    void Update(){

        //Stops the players movement when inside of a panel for crafting. 
        if(ThisManager.anyMenuOpen){
            buttonX = 0f;
            buttonY = 0f;
        }
        //Else will let the player move as normal.
        else{
        buttonX = Input.GetAxis("Horizontal");
        buttonY = Input.GetAxis("Vertical");
    }

        //The players rotate is changing based on when the player is moving left or right. this keeps it updated. 
        Player.eulerAngles = new Vector3(Xrotate, Yrotate, 0f);
        
        //animator for character
        animator.SetFloat("Hmove", buttonX);
        animator.SetFloat("Vmove", buttonY);

        //This sets the rotates. 
        if (buttonX < 0f){
           Yrotate = 180f;
        }
        if (buttonX > 0f){
           Yrotate = 0f;
        }

        //Escape button to open a new panel to exit, or to simply save. 
        if(Input.GetKeyDown(KeyCode.Escape)) ThisManager.TogglePauseMenu( true );
}

    void FixedUpdate(){
		//Setting the velocity and controlling the speed. 
        RigidBodyChar.velocity = new Vector3(buttonX * speed, RigidBodyChar.velocity.y, 0f);
        RigidBodyChar.velocity = new Vector3(RigidBodyChar.velocity.x, buttonY * speed, 0f);
    }


    void OnCollisionEnter2D(Collision2D Interact){

<<<<<<< HEAD
        //Picking up a wood material if no other materials are picked up. 
       // if (Interact.gameObject.tag == "Wood" && ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){
       //     ThisManager.MWood = true;
       // }
       // else if (ThisManager.MWood == true || ThisManager.MMetal == true || ThisManager.MMithral == true){
       // }

        //Picking up a Metal material if no other materials are picked up. 
       // if (Interact.gameObject.tag == "Metal" && ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){
        //    ThisManager.MMetal = true;
       // }
       // else if (ThisManager.MWood == true || ThisManager.MMetal == true || ThisManager.MMithral == true){
      //  }

        //Picking up a Mithral material if no other materials are picked up. 
        //if (Interact.gameObject.tag == "Mithral" && ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){
        //    ThisManager.MMithral = true;
      //  }
      //  else if (ThisManager.MWood == true || ThisManager.MMetal == true || ThisManager.MMithral == true){
      //  }

        //Interacting with the hilt table using tag check. if true goes to hiltmaker function. if materials are false does nothing.
      //  if (Interact.gameObject.tag == "HiltTable"){
          //  if(ThisManager.MWood == true){
          //      HiltMaker();
        //    }
       // }
      //  else if (ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){
       // }
=======
        //Interacting with the hilt table using tag check. if true goes to hiltmaker function. if materials are false does nothing.
        if (Interact.gameObject.tag == "HiltTable"){
            if( ThisManager.carryingAlloy && ThisManager.carryingAlloy.name == "Wood" ){
                ThisManager.ToggleHiltMaker( true );
            }
        }
>>>>>>> CraftingAdvice

        //Interacting with the Weapon table using a tag check. if true goes to Blademaker function. if materials are false does nothing.
        if (Interact.gameObject.tag == "WeaponTable"){
            if(ThisManager.carryingAlloy){
                ThisManager.ToggleWeaponPanel( true );
            }
        }

        //interaction with Anvil if a hilt and weapon are made. 
        if(Interact.gameObject.tag == "Anvil")
        {
            if(ThisManager.craftedHead && ThisManager.craftedHilt)
            {
                ThisManager.ToggleCraftPanel( true );
            }
        }

        //Trash check. goes to clearallbools function. 
        if(Interact.gameObject.tag == "Trash"){
            ThisManager.carryingAlloy = null;
            ThisManager.craftedHead = null;
            ThisManager.craftedHilt = null;
        }
    }

    public void PickupAlloy( Alloy alloyToPickUp )
    {
        ThisManager.carryingAlloy = alloyToPickUp;
    }
<<<<<<< HEAD

    public void OpenHiltMaker(){
        if (ThisManager.carryingAlloy != null){
            ThisManager.HiltMaker();
        }
    }

    void OnCollisionExit2D(Collision2D Interact){

        //Sets all crafting menus to false on exit of touching. 
        ThisManager.Hilt = false;
        ThisManager.Blade = false;
        ThisManager.Crafting = false;
    }

    //Hilt maker function for when you touch the hilt table. 
  //  public void HiltMaker(){
    //    ThisManager.Hilt = true;
  //  }

    //Blade maker function for when touching the weapon table. 
    public void BladeMaker(){
        ThisManager.Blade = true;
    }

    //Open menu function, starts coroutine with IEnumerator menu delay to wait .1f seconds. toggles quitmenu.  
    public void OpenMenu(){
        StartCoroutine(MenuDelay());
        }
    IEnumerator MenuDelay(){
        yield return new WaitForSeconds(.1f);
        ThisManager.QuitMenu = !ThisManager.QuitMenu;   
    }
=======
>>>>>>> CraftingAdvice
}
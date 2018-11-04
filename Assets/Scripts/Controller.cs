using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Transform Player;
    public BoxCollider2D Mycollidor;
    public Rigidbody2D RigidBodyChar;
    public float speed;
    private float buttonX;
    private float buttonY;
    private float Yrotate = 0f;
    private float Xrotate = 0f;
    public Manager ThisManager;
    public WeaponInventory ThisInventory;
   // public Animator animator;

    // Update is called once per frame
    void Update(){

    	// variables for movement and animation
        buttonX = Input.GetAxis("Horizontal");
        buttonY = Input.GetAxis("Vertical");
        Player.eulerAngles = new Vector3(Xrotate, Yrotate, 0f);
        //animator for character
        //animator.SetFloat("Hmove", buttonX);

        if (buttonX < 0f){
           Yrotate = 180f;
        }
        if (buttonX > 0f){
           Yrotate = 0f;
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            OpenMenu();
    }
}

    void FixedUpdate(){
		//speed of the character
        RigidBodyChar.velocity = new Vector3(buttonX * speed, RigidBodyChar.velocity.y, 0f);
        RigidBodyChar.velocity = new Vector3(RigidBodyChar.velocity.x, buttonY * speed, 0f);
    }


    void OnCollisionEnter2D(Collision2D Interact){
        if (Interact.gameObject.tag == "Wood" && ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){
            ThisManager.MWood = true;
        }
        else if (ThisManager.MWood == true || ThisManager.MMetal == true || ThisManager.MMithral == true){

        }
        if (Interact.gameObject.tag == "Metal" && ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){
            ThisManager.MMetal = true;
        }
        else if (ThisManager.MWood == true || ThisManager.MMetal == true || ThisManager.MMithral == true){

        }
        if (Interact.gameObject.tag == "Mithral" && ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){
            ThisManager.MMithral = true;
        }
        else if (ThisManager.MWood == true || ThisManager.MMetal == true || ThisManager.MMithral == true){

        }
        if (Interact.gameObject.tag == "HiltTable"){
            if(ThisManager.MWood == true){
                HiltMaker();
            }
        }
        else if (ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){

        }
        if (Interact.gameObject.tag == "WeaponTable"){
            if(ThisManager.MWood == true || ThisManager.MMetal == true || ThisManager.MMithral == true){
                BladeMaker();
            }
        }
        else if (ThisManager.MWood == false && ThisManager.MMetal == false && ThisManager.MMithral == false){

        }
        if(Interact.gameObject.tag == "Anvil")
        {
            if(ThisManager.Headslot && ThisManager.Hiltslot == true)
            {
                ThisManager.Crafting = true;
            }
        }
        if(Interact.gameObject.tag == "Trash"){
            ThisManager.Clearallbools();
        }
        



    }
    void OnCollisionExit2D(Collision2D Interact){
        ThisManager.Hilt = false;
        ThisManager.Blade = false;
        ThisManager.Crafting = false;
    }

    public void HiltMaker(){
        ThisManager.Hilt = true;
    }
    public void BladeMaker(){
        ThisManager.Blade = true;
    }
    public void OpenMenu(){
        StartCoroutine(MenuDelay());
        }
    IEnumerator MenuDelay(){
        yield return new WaitForSeconds(.1f);
        ThisManager.QuitMenu = !ThisManager.QuitMenu;
        
    }
 
}


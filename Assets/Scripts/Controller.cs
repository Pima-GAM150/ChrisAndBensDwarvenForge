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
    }

    void FixedUpdate(){
		//speed of the character
        RigidBodyChar.velocity = new Vector3(buttonX * speed, RigidBodyChar.velocity.y, 0f);
        RigidBodyChar.velocity = new Vector3(RigidBodyChar.velocity.x, buttonY * speed, 0f);
    }


    void OnCollisionEnter2D(Collision2D Interact){
        if (Interact.gameObject.tag == "Anvil"){
            ThisManager.Crafting = true;
        }
        



    }
    void OnCollisionExit2D(Collision2D Interact){
        ThisManager.Crafting = false;
    }
 
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public Transform Player;
    public BoxCollider2D Mycollidor;
    public Rigidbody2D RigidBodyChar;
    public Animator animator;
    public float speed;
    
   //	private CollisionDetectionMode2D TheGround;
    private bool Grounded = false;
    private float buttonX;
    private float buttonY;

    // Update is called once per frame
    void Update(){

    	// variables for movement and animation
        buttonX = Input.GetAxis("Horizontal");
        buttonY = Input.GetAxis("Vertical");

        //animator for character
        //animator.SetFloat("Hmove", buttonX);

        //   if (buttonX < 0f){
        //   Player.eulerAngles = new Vector3(0f, 180f, 0f);
        //}
        //   if (buttonX > 0f){
        //   Player.eulerAngles = new Vector3(0f, 0f, 0f);
    }

    void FixedUpdate()
        {
		//speed of the character
        RigidBodyChar.velocity = new Vector3(buttonX * speed, RigidBodyChar.velocity.y, 0f);
        RigidBodyChar.velocity = new Vector3(RigidBodyChar.velocity.x, buttonY * speed, 0f);
    }
 
}
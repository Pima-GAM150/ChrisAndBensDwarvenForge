using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    //Script for Controlling the camera and making it follown the player in a 2D space. 

    //Speed is for managing the lerp effect
    public float speed;
    //Players transform for position
    public Transform player;
    //Cameras transform for camera position
    public Transform PlayerViewer;
    //Vector3 for offest between the two transforms. 
    private Vector3 camOffsetFromPlayer;

    void Start()
    {
        //Player position minus the camera position creates the offset vector3 in void start.
        camOffsetFromPlayer = player.position - PlayerViewer.position;
    }
    void Update()
    {
        //Every frame the players camera position will follow the players minus the offset that was set in the void start. 
        //Lerp effect is used to control how fast it will reassign itself using the speed. 
        PlayerViewer.position = Vector3.Lerp(PlayerViewer.position, player.position - camOffsetFromPlayer, speed);
    }
}

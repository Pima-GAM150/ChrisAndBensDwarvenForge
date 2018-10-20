using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public float speed;

    public Transform player;
    public Transform PlayerViewer;

    private Vector3 camOffsetFromPlayer;

    void Start()
    {
        camOffsetFromPlayer = player.position - PlayerViewer.position;
    }
    void Update()
    {
        PlayerViewer.position = Vector3.Lerp(PlayerViewer.position, player.position - camOffsetFromPlayer, speed);
    }
}

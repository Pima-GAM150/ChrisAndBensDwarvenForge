using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour {

    public Alloy alloyInBucket;

    public void OnCollisionEnter2D(Collision2D col)
    {
        print("Bucket colliding with " + col.collider.name);
        Controller player = col.collider.GetComponent<Controller>();

        if( player )
        {
            player.PickupAlloy(alloyInBucket);
        }
    }
}

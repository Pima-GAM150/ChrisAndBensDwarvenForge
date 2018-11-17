using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiltTable : MonoBehaviour {

	public void OnCollisionEnter2D(Collision2D col){
		Controller player = col.collider.GetComponent<Controller>();

        if( player )
        {
            player.OpenHiltMaker();
        }
	}

}

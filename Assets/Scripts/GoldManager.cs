using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviour {

	public static GoldManager singleton;
	public int Gold;

	// Use this for initialization
	void Start () {
		if(singleton != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

	public AudioSource SmithSound;

	public void PlaySmithSound(){
		SmithSound.Play(0);
	}
}

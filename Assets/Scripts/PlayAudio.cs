using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

	public AudioSource SmithSound;
	public AudioSource StepSound;

	public void PlaySmithSound(){
		SmithSound.Play(0);
	}

	public void PlayStepSound(){
		StepSound.Play(0);
		print("Yo");
	}
}

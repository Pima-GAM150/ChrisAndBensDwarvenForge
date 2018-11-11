using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenePlay : MonoBehaviour {
	//Loads scene with transition. 

	//Level to load with transition animation variables.
	public string LevelToLoad;
	public Animator Transition;

	//Function loadthis called by pressing the button. starts coroutine.
	public void loadthis(){
		StartCoroutine(LoadScenePlease());
	}

	//Plays 1 second long transition animation and then waits 1 second before loading new scene. 
	IEnumerator LoadScenePlease(){
		Transition.SetTrigger("end");
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(LevelToLoad);
	}
}

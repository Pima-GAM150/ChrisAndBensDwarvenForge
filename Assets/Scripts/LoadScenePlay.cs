using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenePlay : MonoBehaviour {

	public string LevelToLoad;
	public Animator Transition;

	public void loadthis(){

		StartCoroutine(LoadScenePlease());
		
	}
	IEnumerator LoadScenePlease(){

		Transition.SetTrigger("end");
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(LevelToLoad);
	}
}

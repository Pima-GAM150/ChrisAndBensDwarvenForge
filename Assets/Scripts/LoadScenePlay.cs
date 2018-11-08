using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenePlay : MonoBehaviour {

	public string LevelToLoad;
	public Animator Transition;
	public GameObject Button;
	public GameObject Buttontwo;

	public void loadthis(){

		StartCoroutine(LoadScenePlease());
		
	}
	IEnumerator LoadScenePlease(){

		Button.SetActive(false);
		Buttontwo.SetActive(false);
		Transition.SetTrigger("end");
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(LevelToLoad);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SequenceManager : MonoBehaviour {

	[SerializeField] string nextScene;
	[SerializeField] string lastScene;
	[SerializeField] GameObject continueButton;
	[SerializeField] bool isReady = false;

	private void Start()
	{
		continueButton.SetActive(isReady);
	}

	public void LoadLastScene()
	{
		SceneManager.LoadScene(lastScene);
	}
	public void LoadNextScene()
	{
		SceneManager.LoadScene(nextScene);
	}
	public void ActivateContinue()
	{
		continueButton.SetActive(true);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour {
	GameObject menu;
	// Use this for initialization
	void Start () {
		menu = GameObject.Find("MenuCanvas");
		menu.SetActive(!menu.activeInHierarchy);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			menu.SetActive(!menu.activeInHierarchy);
		}
	}

	public void ContinuePressed()
	{
		menu.SetActive(!menu.activeInHierarchy);
	}

	public void ExitPressed()
	{
		Application.Quit();
	}

	public void TitlePressed()
	{
		SceneManager.LoadScene("Title");
	}
}

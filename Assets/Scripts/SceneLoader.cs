using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public void LoadScenarioSelector()
	{
		SceneManager.LoadScene("Game Select");
	}
	public void LoadMenu()
	{
		SceneManager.LoadScene("Title");
	}
	public void LoadIntro()
	{
		SceneManager.LoadScene("Intro");
	}
	public void LoadGrassland()
	{
		SceneManager.LoadScene("Grassland");
	}
	public void LoadTundra()
	{
		SceneManager.LoadScene("Tundra");
	}
	public void LoadDesert()
	{
		SceneManager.LoadScene("Desert");
	}
}

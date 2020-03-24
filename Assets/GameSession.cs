using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

	private void Awake()
	{
		SetUpSingleton();
	}

	private void SetUpSingleton()
	{
		int numberGameSessions = FindObjectsOfType<GameSession>().Length;
		if (numberGameSessions > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	}

	public void ResetGame()
	{
		Destroy(gameObject);
	}
}


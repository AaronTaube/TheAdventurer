using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class StoryMechanics : MonoBehaviour {

	[SerializeField] TextMeshProUGUI storyTextComponent;
	[SerializeField] TextMeshProUGUI titleTextComponent;
	[SerializeField] State startingState;
	[SerializeField] GameObject player;

	int health = 100;
	State state;
	// Use this for initialization
	void Start () {
		state = startingState;
		storyTextComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
		ManageState();
	}

	void ManageState()
	{
		var nextStates = state.GetNextStates();
		bool isReactionState;
		if(nextStates.Length > 2)
		{
			isReactionState = false;
		}
		else
		{
			isReactionState = true;
		}

		if (isReactionState)
		{
			ManageReactionState(nextStates);
		}
		else
		{
			ManageScenarioState(nextStates);
		}
	}

	private void ManageReactionState(State[] nextStates)
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (health > 0)
				state = nextStates[0];
			else
				state = nextStates[1];
		}
	}

	private void ManageScenarioState(State[] nextStates)
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			state = nextStates[0];
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			state = nextStates[1];
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			state = nextStates[2];
		}
		else if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			state = nextStates[3];
		}
		storyTextComponent.text = state.GetStateStory();
		titleTextComponent.text = state.GetStateTitle();
	}
}

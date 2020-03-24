using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
	[TextArea(1, 1)] [SerializeField] string titleText;
	[TextArea(14, 10)] [SerializeField] string storyText;

	[SerializeField] State[] nextState;
	
	public string GetStateStory()
	{
		return storyText;
	}
	public string GetStateTitle()
	{
		return titleText;
	}
	public State[] GetNextStates()
	{
		return nextState;
	}
}

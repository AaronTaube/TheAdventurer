using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateChoice : MonoBehaviour {
	[SerializeField] Animator ani;
	//[SerializeField] AudioSource sound;
	AudioSource sound;
	// Use this for initialization
	void Start () {
		ani.enabled = false;
		//sound.enabled = false;
		sound = GetComponent<AudioSource>();
	}
	
	public void Chosen()
	{
		//sound.enabled = true;
		sound.volume = .1f;
		sound.Play(0);
		ani.enabled = true;
	}
}

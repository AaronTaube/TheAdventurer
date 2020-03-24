using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {
	bool isActive = false;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Blinking", .5f, .5f);
	}

	

	// Update is called once per frame
	void Update () {
		
	}
	void Blinking()
	{
		
		isActive = !isActive;
		gameObject.SetActive(isActive);
		

	}
}

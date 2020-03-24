using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightChoice : MonoBehaviour {
	SequenceManager manage;
	// Use this for initialization
	void Start () {
		manage = GameObject.Find("Sequence Controller").GetComponent<SequenceManager>();
	}
	
	public void Chosen()
	{
		StartCoroutine(UpdateStatus());
		
	}

	IEnumerator UpdateStatus()
	{
		yield return new WaitForSeconds(1);
		manage.ActivateContinue();
	}
}

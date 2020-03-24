using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour {
	[SerializeField] AudioClip bodySound;
	[SerializeField] AudioClip oneSound;
	[SerializeField] AudioClip twoSound;
	[SerializeField] AudioClip threeSound;
	[SerializeField] AudioClip animalSound;
	public void PlayBodyText()
	{
		AudioSource.PlayClipAtPoint(bodySound, transform.position);
	}
	public void PlayOptionOne()
	{
		AudioSource.PlayClipAtPoint(oneSound, transform.position, 1000000);
	}
	public void PlayOptionTwo()
	{
		AudioSource.PlayClipAtPoint(twoSound, transform.position);
	}
	public void PlayOptionThree()
	{
		AudioSource.PlayClipAtPoint(threeSound, transform.position);
	}
	public void PlayAnimalSound()
	{
		AudioSource.PlayClipAtPoint(animalSound, transform.position);
	}
}

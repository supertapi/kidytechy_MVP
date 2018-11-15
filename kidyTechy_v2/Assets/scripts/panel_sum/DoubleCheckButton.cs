using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleCheckButton : MonoBehaviour {

	public AudioSource failAudioSource;
	public AudioClip failClip;

	// Use this for initialization
	public void onclickDoubleCheckButton(){
		failAudioSource.PlayOneShot(failClip, 1f);
	}
}

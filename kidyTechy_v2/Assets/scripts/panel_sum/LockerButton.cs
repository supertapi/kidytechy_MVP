using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerButton : MonoBehaviour {

	public AudioSource successAudioSource;
	public AudioClip successAudioClip;

	public GameObject panelSum;
	public GameObject wood4;

	public void onClickLocker(){
        successAudioSource.PlayOneShot(successAudioClip, 1f);
		panelSum.SetActive(false);
		wood4.SetActive(true);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslagramButton3 : MonoBehaviour {

    public AudioSource successAudioSource;
    public AudioClip successAudioClip;
	public GameObject panelBunny;
	public GameObject bunnyObj;

	// Use this for initialization
	public void onClickButton3(){
        successAudioSource.PlayOneShot(successAudioClip, 1f);
        panelBunny.SetActive(false);
		bunnyObj.SetActive(false);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickBloqueoButton : MonoBehaviour {

    public AudioSource successAudioSource;
    public AudioClip successAudioClip;
	public GameObject soldierObj;
	public GameObject _panel;

    // Use this for initialization
    public void onclickBloqueoButton()
    {
        successAudioSource.PlayOneShot(successAudioClip, 1f);
        soldierObj.SetActive(false);
        _panel.SetActive(false);
    }
}
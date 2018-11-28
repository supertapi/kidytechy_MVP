using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButtonTortoise1 : MonoBehaviour {

    public AudioSource successAudioSource;
    public AudioClip successAudioClip;
    public GameObject tortoiseObj;
    public GameObject _panelt;

    // Use this for initialization
    public void onclickBloqueoButton()
    {
        successAudioSource.PlayOneShot(successAudioClip, 1f);
        tortoiseObj.SetActive(false);
        _panelt.SetActive(false);
    }
}

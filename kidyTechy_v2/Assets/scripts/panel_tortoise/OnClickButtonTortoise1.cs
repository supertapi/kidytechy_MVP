using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButtonTortoise1 : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclickBloqueoButton()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

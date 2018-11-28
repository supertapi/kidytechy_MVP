using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButtonTortoise3 : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclickTortoiseButton3()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

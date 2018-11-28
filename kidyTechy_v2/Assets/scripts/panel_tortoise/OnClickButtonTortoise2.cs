using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButtonTortoise2 : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclickTortoiseButton2()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

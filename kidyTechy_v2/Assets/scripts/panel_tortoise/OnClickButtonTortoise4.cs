using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButtonTortoise4 : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclickTortoiseButton4()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButon1 : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclickButton1()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickInsulToButton : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclickInsultoButton()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickCompartoInsultoButton : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclicCompartokButton()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

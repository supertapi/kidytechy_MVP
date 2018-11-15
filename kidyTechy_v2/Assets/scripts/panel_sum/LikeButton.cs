using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LikeButton : MonoBehaviour {

	// Use this for initialization
    // Update is called once per frame
    public AudioSource failAudioSource;
    public AudioClip failClip;

    // Use this for initialization
    public void onclickLikeButton()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}

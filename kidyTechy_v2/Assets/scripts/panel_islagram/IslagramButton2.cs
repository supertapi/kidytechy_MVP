﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslagramButton2 : MonoBehaviour {

    public AudioSource failAudioSource;
    public AudioClip failClip;
    public void onclickButton1()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
    }
}
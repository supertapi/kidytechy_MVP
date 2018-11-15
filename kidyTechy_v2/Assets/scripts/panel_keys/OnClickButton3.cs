using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButton3 : MonoBehaviour {

    public AudioSource successAudioSource;
    public AudioClip successAudioClip;

    public GameObject panelKey;
    public GameObject witchObj;

    public void onClickButton3()
    {
        successAudioSource.PlayOneShot(successAudioClip, 1f);
        panelKey.SetActive(false);
        witchObj.SetActive(false);
    }
}

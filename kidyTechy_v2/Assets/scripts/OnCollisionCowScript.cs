using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCowScript : MonoBehaviour {


    public GameObject panel_5_1;
    public AudioSource panelAudioSource;
    public AudioClip panelClip;
    bool cowCollided;


    // Use this for initialization
    void Start () {
        cowCollided = false;
        panel_5_1.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!cowCollided)
        {
            panel_5_1.SetActive(true);
            panelAudioSource.PlayOneShot(panelClip, 1f);
            cowCollided = true;
        }
    }
}

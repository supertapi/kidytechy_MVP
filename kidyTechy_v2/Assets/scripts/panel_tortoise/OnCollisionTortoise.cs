using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionTortoise : MonoBehaviour {

    public GameObject tortoisePanel;
    public AudioSource panelAudioSource;
    public AudioClip panelClip;

    // Use this for initialization
    void Start()
    {
        tortoisePanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
            tortoisePanel.SetActive(true);
            panelAudioSource.PlayOneShot(panelClip, 1f);

    }
}

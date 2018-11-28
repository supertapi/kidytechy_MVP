using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionTortoise : MonoBehaviour {

    public GameObject tortoisePanel;
    public AudioSource panelAudioSource;
    public AudioClip panelClip;
    bool tortoiseCollided;

    // Use this for initialization
    void Start()
    {
        tortoiseCollided = false;
        tortoisePanel.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if (!tortoiseCollided)
        {
            tortoisePanel.SetActive(true);
            panelAudioSource.PlayOneShot(panelClip, 1f);
            tortoiseCollided = true;
        }

    }
}

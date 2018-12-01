using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionBunny : MonoBehaviour {

    public GameObject bunnyPanel;
    public AudioSource panelAudioSource;
    public AudioClip panelClip;
    //bool bunnyCollided;

    // Use this for initialization
    void Start () {
       // bunnyCollided = false;
        bunnyPanel.SetActive(false);
        
    }

    void OnTriggerEnter(Collider other)
    {
        /*
            if(!bunnyCollided) {
                bunnyPanel.SetActive(true);
                panelAudioSource.PlayOneShot(panelClip, 1f);
                bunnyCollided = true;
            }
        */
        bunnyPanel.SetActive(true);
        panelAudioSource.PlayOneShot(panelClip, 1f);
    }
}

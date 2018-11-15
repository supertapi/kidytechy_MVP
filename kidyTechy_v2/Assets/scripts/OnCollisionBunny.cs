using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionBunny : MonoBehaviour {

    public GameObject panel_5_1;
    public AudioSource panelAudioSource;
    public AudioClip panelClip;
    bool bunnyCollided;

    // Use this for initialization
    void Start () {
        bunnyCollided = false;
        panel_5_1.SetActive(false);
        
    }

    void OnTriggerEnter(Collider other)
    {
            if(!bunnyCollided) {
                panel_5_1.SetActive(true);
                panelAudioSource.PlayOneShot(panelClip, 1f);
                bunnyCollided = true;
            }
            
    }
}

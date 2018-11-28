using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionSoldier : MonoBehaviour {
	public GameObject soldierPanel;
    public AudioSource panelAudioSource;
    public AudioClip panelClip;
    bool soldierCollided;
	// Use this for initialization
	void Start () {
		soldierCollided = false;
		soldierPanel.SetActive(false);
	}

    void OnTriggerEnter(Collider other)
    {
        if (!soldierCollided)
        {
            soldierPanel.SetActive(true);
            panelAudioSource.PlayOneShot(panelClip, 1f);
            soldierCollided = true;
        }

    }
}

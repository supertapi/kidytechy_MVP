using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionWitch : MonoBehaviour {

	public GameObject panelKeys;
    public AudioSource panelAudioSource;
    public AudioClip panelClip;

	// Use this for initialization
	void Start () {
        panelKeys.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        panelKeys.SetActive(true);
        panelAudioSource.PlayOneShot(panelClip, 1f);
    }
}

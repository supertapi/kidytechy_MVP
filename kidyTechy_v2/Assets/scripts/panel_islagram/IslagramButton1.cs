using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IslagramButton1 : MonoBehaviour
{
    public AudioSource failAudioSource;
    public AudioClip failClip;
    public GameObject _boy;
    public Transform _teleportPoint;
    public GameObject _bunnyPanel;

    public void onclickButton1()
    {
        failAudioSource.PlayOneShot(failClip, 1f);
        _bunnyPanel.SetActive(false);
        _boy.transform.position = _teleportPoint.position;
    }
	
}

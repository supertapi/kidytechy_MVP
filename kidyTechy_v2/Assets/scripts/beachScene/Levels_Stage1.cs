using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels_Stage1 : MonoBehaviour {
	public GameObject dogPanel;
	bool showPanel;

	public AudioSource tragedyAS;
	public AudioClip tragedyClip;
	
	// Use this for initialization
	void Start () {
        showPanel = false;
		dogPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(OnTrackBeach.beachChecked==true && !showPanel){
			Invoke("showDogPanel", 3f);
			showPanel = true;
		}
	}

	void showDogPanel(){
		dogPanel.SetActive(true);
		tragedyAS.PlayOneShot(tragedyClip, 1f);
        Invoke("hideDogPanel", 5f);
        
	}
    void hideDogPanel()
    {
        dogPanel.SetActive(false);
    }
}

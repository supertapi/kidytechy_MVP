using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class OnTrackSmallCube : MonoBehaviour, ITrackableEventHandler {

	public static bool smallChecked; 
	public GameObject smallCube;
    public GameObject mediumCube;
    public GameObject largeCube;

    private TrackableBehaviour mTrackableBehaviour;

	// Use this for initialization
	void Start () {
		
		smallChecked = false;

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
	}

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == null)
            throw new System.ArgumentNullException("newStatus");

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            smallChecked = true;
			smallCube.SetActive(true);

            if (smallCube.active && mediumCube.active && largeCube.active)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

    // Update is called once per frame
    public void OnTrackableStateChanged(TrackableBehaviour.Status newStatus)
    {
        OnTrackableStateChanged(default(TrackableBehaviour.Status), newStatus);
    }

    public static bool isChecked()
    {
        return smallChecked;
    }
}

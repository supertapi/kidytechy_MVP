using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class OnTrackLargeCube : MonoBehaviour, ITrackableEventHandler {

	public static bool largeChecked;
	public GameObject largeCube;

    public GameObject mediumCube;
    public GameObject smallCube;
    private TrackableBehaviour mTrackableBehaviour;

	// Use this for initialization
	void Start () {
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
            largeChecked = true;
            largeCube.SetActive(true);

            if(smallCube.active && mediumCube.active && largeCube.active){
                SceneManager.LoadScene(3);
            }
        }
    }

    // Update is called once per frame
    public void OnTrackableStateChanged(TrackableBehaviour.Status newStatus)
    {
        OnTrackableStateChanged(default(TrackableBehaviour.Status), newStatus);
    }

    public static bool isChecked(){
        return largeChecked;
    }
}

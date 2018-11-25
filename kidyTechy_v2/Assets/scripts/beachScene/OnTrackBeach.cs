using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OnTrackBeach : MonoBehaviour, ITrackableEventHandler
{
    public static bool beachChecked;
    private TrackableBehaviour mTrackableBehaviour;
  
    //boatObj.SetActive(false);
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == null)
            throw new System.ArgumentNullException("newStatus");

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            beachChecked = true;
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status newStatus)
    {
        OnTrackableStateChanged(default(TrackableBehaviour.Status), newStatus);
    }

    // Use this for initialization
    void Start () {
        beachChecked = false;

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OnTrackBridgePart001 : MonoBehaviour, ITrackableEventHandler {

    private TrackableBehaviour mTrackableBehaviour;
    GameObject cwood1Obj;
    GameObject bridgePart1Obj;
    GameObject bridgePart2Obj;
    GameObject bridgePart3Obj;

    // Use this for initialization
    void Start() {
        bridgePart1Obj = GameObject.Find("Cwood1");
        bridgePart2Obj = GameObject.Find("Cwood2");
        bridgePart3Obj = GameObject.Find("Cwood3");
        bridgePart1Obj.SetActive(false);
        bridgePart2Obj.SetActive(false);
        bridgePart3Obj.SetActive(false);

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (Levels.getLevel()==1)
            {
                bridgePart1Obj.SetActive(true);
                bridgePart2Obj.SetActive(true);
                bridgePart3Obj.SetActive(true);
                Levels.setLevel(3);
            }
            
        }
    }

    //event that is launched qhen the as is detected
    public void OnTrackableStateChanged(TrackableBehaviour.Status newStatus)
    {
        OnTrackableStateChanged(default(TrackableBehaviour.Status), newStatus);
    }
}

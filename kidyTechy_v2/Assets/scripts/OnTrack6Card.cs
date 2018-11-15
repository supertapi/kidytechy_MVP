using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OnTrack6Card : MonoBehaviour, ITrackableEventHandler {

    public GameObject bunnyPanel;
    ParticleSystem particleCarrot;
    GameObject panel_5_1;
    public GameObject carrot;

    private TrackableBehaviour mTrackableBehaviour;

    // Use this for initialization
    void Start () {
        panel_5_1 = GameObject.Find("Panel_sum");
        bunnyPanel.SetActive(false);
        particleCarrot = GameObject.Find("particle_carrot").GetComponent<ParticleSystem>();

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
            bunnyPanel.SetActive(true);
            particleCarrot.Play();
            panel_5_1.SetActive(false);
            carrot.SetActive(true);
        }
    }

    //event that is launched qhen the as is detected
    public void OnTrackableStateChanged(TrackableBehaviour.Status newStatus)
    {
        OnTrackableStateChanged(default(TrackableBehaviour.Status), newStatus);
    }
}

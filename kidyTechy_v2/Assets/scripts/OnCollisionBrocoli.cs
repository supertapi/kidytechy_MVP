using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionBrocoli : MonoBehaviour {

    GameObject questionMark2;
    GameObject bridgePart1Obj;
    GameObject bridgePart2Obj;
    GameObject bridgePart3Obj;
    ParticleSystem powerTortoise;
    ParticleSystem carrotParti;
    public GameObject broccoli;

    // Use this for initialization
    void Start () {
        bridgePart1Obj = GameObject.Find("Cwood1");
        bridgePart2Obj = GameObject.Find("Cwood2");
        bridgePart3Obj = GameObject.Find("Cwood3");
        powerTortoise = GameObject.Find("power_06").GetComponent<ParticleSystem>();
        carrotParti = GameObject.Find("magic_ring_03").GetComponent<ParticleSystem>();
        powerTortoise.Stop();
        broccoli = GameObject.Find("Broccoli");
    }

    void OnTriggerEnter(Collider other)
    {
        if (Levels.getLevel()==1)
        {
            Levels.setBrocoliChecked(true);
            Levels.setLevel(3);
            bridgePart1Obj.SetActive(true);
            bridgePart2Obj.SetActive(true);
            bridgePart3Obj.SetActive(true);
            powerTortoise.Play();
            Invoke("stopCarrotParticle", 3);
            broccoli.SetActive(false);
        }
    }

    void stopCarrotParticle()
    {
        carrotParti.Stop();
    }
}

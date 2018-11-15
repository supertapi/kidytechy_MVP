using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCarrot : MonoBehaviour {

    GameObject wood5Obj;
    ParticleSystem particleCarrot;
    ParticleSystem powerCarrot;
    //ParticleSystem magicRing_1;
    GameObject tinker1;
    public GameObject carrot;
    GameObject panel_5_1;
    public GameObject panelBunnyCarrot;

    // Use this for initialization
    void Start () {
        wood5Obj = GameObject.Find("wood5");
        wood5Obj.SetActive(false);
        Levels.setLevel(0);
        particleCarrot = GameObject.Find("particle_carrot").GetComponent<ParticleSystem>();
        powerCarrot = GameObject.Find("particle_power_carrot").GetComponent<ParticleSystem>();
        //magicRing_1 = GameObject.Find("magic_ring_01").GetComponent<ParticleSystem>();
        particleCarrot.Stop();
        powerCarrot.Stop();
        tinker1 = GameObject.Find("tinker_1");
        tinker1.SetActive(false);
        panel_5_1 = GameObject.Find("Panel_sum");
        panel_5_1.SetActive(false);
        carrot.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (Levels.getLevel() == 0)
        {
            Levels.setLevel(1);
            wood5Obj.SetActive(true);
            particleCarrot.Play();
            powerCarrot.Play();
            Invoke("stopParticleCarrot", 2);
            Invoke("stopPowerCarrot", 2);
            //Invoke("stopMagicRing", 2);
            tinker1.SetActive(true);
            carrot.SetActive(false);
            panelBunnyCarrot.SetActive(false);
        }
    }

    void stopParticleCarrot()
    {
        particleCarrot.Stop();
    }

    void stopPowerCarrot()
    {
        powerCarrot.Stop();
    }

    void stopMagicRing()
    {
       // magicRing_1.Stop();
    }
}

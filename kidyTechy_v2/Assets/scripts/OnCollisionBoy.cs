using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using DentedPixel;
using UnityEngine.SceneManagement;

public class OnCollisionBoy : MonoBehaviour {

    GameObject boyObj;
    Vector3 moveDirection = Vector3.zero;
    public static int boyCollisionStatus = 0;
    Animator animBoy;
    Animator witchAnim;
    GameObject witch;
    public GameObject panelBunny;
    public GameObject panelSum;

    float gravity = 19;

    // Use this for initialization
    void Start () {
        boyObj = GameObject.Find("boy");
        witch = GameObject.Find("ChaWitch");
        animBoy = boyObj.GetComponent<Animator>();
        witchAnim = witch.GetComponent<Animator>();

    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(boyObj.name + " collided with " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other) {
        if(other.GetInstanceID().Equals("boy")){
            
            if (panelBunny.activeSelf == true)
                {
                    panelBunny.SetActive(false);
                }

                if (panelSum.activeSelf == true)
                {
                    panelSum.SetActive(false);
                }

                witchAnim.Play("Witch_Attack");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCowScript : MonoBehaviour {

    GameObject boyObj;
    GameObject canvasObj;
    public Canvas EscCan;

    // Use this for initialization
    void Start () {
        boyObj = GameObject.Find("boy");

        canvasObj = GameObject.Find("Challenge_math");

        /*if (canvasObj != null)
        {
            EscCan = canvasObj.GetComponent<Canvas>();
            if (EscCan == null)
            {
                Debug.Log("Could not locate Canvas component on " + canvasObj.name);
            }
        }*/

        EscCan.enabled = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(boyObj.name + " collided with " + collision.gameObject.name);

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(boyObj.name + " has triggered " + other.gameObject.name);
        if (Levels.getLevel() == 3)
        {
            EscCan.enabled = true;
        }
    }
}

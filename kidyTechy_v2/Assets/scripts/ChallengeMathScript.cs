using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChallengeMathScript : MonoBehaviour {

    Canvas EscCan;
    GameObject canvasObj;

    // Use this for initialization
    void Start () {
        canvasObj = GameObject.Find("Challenge_math");

        if (canvasObj != null)
        {
            EscCan = canvasObj.GetComponent<Canvas>();
            if (EscCan == null)
            {
                Debug.Log("Could not locate Canvas component on " + canvasObj.name);
            }
        }

        EscCan.enabled = false;
    }
	
	public void check10button()
    {
        if (EscCan.isActiveAndEnabled)
        {
            EscCan.enabled = false;
            SceneManager.LoadScene(3);
        }
    }

}

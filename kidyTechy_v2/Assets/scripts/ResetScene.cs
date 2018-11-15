using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour {

    GameObject boyObj;

	// Use this for initialization
	void Start () {
        boyObj = GameObject.Find("boy");
    }

    public void resetScene2()
    {
        SceneManager.LoadScene(2);
    }

     /*void OnCollisionEnter(Collision collision)
    {
       
            Debug.Log("Reseted");
            //SceneManager.LoadScene(2);
            //Application.LoadLevel(Application.loadedLevel);
        
    }*/
}

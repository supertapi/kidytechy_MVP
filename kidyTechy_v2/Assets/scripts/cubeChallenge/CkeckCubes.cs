using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CkeckCubes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (OnTrackLargeCube.isChecked() && OnTrackMediumCube.isChecked() && OnTrackSmallCube.isChecked())
        {
            SceneManager.LoadScene(3);
        }
	}
}

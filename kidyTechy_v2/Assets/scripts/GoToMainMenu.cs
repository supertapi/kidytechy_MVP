using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class GoToMainMenu : MonoBehaviour {

    public void gotoBeachScene()
    {
        SceneManager.LoadScene(1);
    }

}

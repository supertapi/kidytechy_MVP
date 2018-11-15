using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {

    private static int currentLevel = 0;

    private static bool brocoliChecked = false;
    private static bool card6Checked = false;
    
    //cubes
    public GameObject smallCube;
    public GameObject mediumCube;
    public GameObject largeCube;
    public GameObject wood4;

    public void Start() {
        wood4.SetActive(false);
        //cubes
        smallCube.SetActive(false);
        mediumCube.SetActive(false);
        largeCube.SetActive(false);
    }

    public static int getLevel() {
        return currentLevel;
    }

    public static void setLevel(int _newLevel) {
        currentLevel = _newLevel;
    }

    public static bool isBrocoliChecked()
    {
        return brocoliChecked;
    }

    public static void setBrocoliChecked(bool _newStatus)
    {
        brocoliChecked = _newStatus;
    }

    public static void setCard6Checked(bool _newStatus)
    {
        card6Checked = _newStatus;
    }

    public static bool isCard6Checked()
    {
        return card6Checked;
    }
}

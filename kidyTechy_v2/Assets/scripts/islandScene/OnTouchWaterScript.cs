using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchWaterScript : MonoBehaviour {
	public GameObject startPoint;
	public GameObject point1;
	public GameObject point2;
	public GameObject point3;
	public GameObject boyObj;
	public int islandIndex;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
		if(islandIndex == 0) {
            boyObj.transform.position = startPoint.transform.position;

		} else if(islandIndex == 1){
			boyObj.transform.position = point1.transform.position;

		} else if(islandIndex == 2){
			boyObj.transform.position = point2.transform.position;

		} else if(islandIndex== 3){
            boyObj.transform.position = point3.transform.position;
		}
       
    }
}

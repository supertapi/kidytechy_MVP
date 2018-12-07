using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyFollowByWitch : MonoBehaviour {

    public Transform _target;
    public float actionRadio = 10f;
    public float aimRadio = 30f;

    public float _speed = 5f;

    float _distance;
    Animator _anim;


    // Use this for initialization
    void Start () {
        _anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        _distance = Vector3.Distance(transform.position, _target.position);

        if (_distance < aimRadio)
        {
            transform.LookAt(_target);
        }

        if (Vector3.Distance(transform.position, _target.position) < actionRadio)
        {
            Vector3 enemyPos = transform.position;
            Vector3 objetivoPos = _target.position;

            //Debug.Log("Estoy en la zona");

            enemyPos.y = transform.position.y;

            transform.position = Vector3.MoveTowards(enemyPos, objetivoPos, _speed * Time.deltaTime);
            _anim.SetBool("Witch_Walk", true);
        }

    }
	
}

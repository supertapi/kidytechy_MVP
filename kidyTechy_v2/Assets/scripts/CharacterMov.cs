using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.EventSystems;

public class CharacterMov : MonoBehaviour {
	float speed = 7;
	float gravity = 15;
	CharacterController controller;
	Vector3 moveDirection = Vector3.zero;
    GameObject boyObj;
    Animator anim;

    // Use this for initialization
    void Start () {
        boyObj = GameObject.Find("boy");
        anim = boyObj.GetComponent<Animator>();
        controller = transform.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//APPLY GRAVITY
		if(moveDirection.y > gravity * -1) {
			moveDirection.y -= gravity * Time.deltaTime;
		}
		controller.Move(moveDirection * Time.deltaTime);
		var left = transform.TransformDirection(Vector3.left);

		if(controller.isGrounded) {

            //JUMP
            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.Play("jump1");
                moveDirection.y = speed;

            } else if (Input.GetKey(KeyCode.UpArrow)) {

                //LeanTween.rotateY(boyObj, 0.0f, 0.5f);
                anim.Play("run");
                controller.SimpleMove(Vector3.forward * speed * 2);
                //controller.transform.Rotate(Vector3.up, -180.0f);
                
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {

                //LeanTween.rotateY(boyObj, 0.0f, 0.5f);
                anim.Play("run");
                controller.SimpleMove(Vector3.back * speed * 2);
                //controller.transform.Rotate(Vector3.up, 0.0f);

            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {

                //LeanTween.rotateY(boyObj, 0.0f, 0.5f);
                anim.Play("run");
                controller.SimpleMove(Vector3.left * speed * 2);
                //controller.transform.Rotate(Vector3.up, -90.0f);

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {

                //LeanTween.rotateY(boyObj, 0.0f, 0.5f);
                anim.Play("run");
                controller.SimpleMove(Vector3.right * speed * 2);
                //controller.transform.Rotate(Vector3.up, -90.0f);

            }*/


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DentedPixel;

public class JoystickBoy : MonoBehaviour
{
    float speed = 12;
    Vector2 joystickCenter = Vector2.zero;
    CharacterController controller;
    GameObject boyObj;
    Animator anim;
    public float moveSpeed = 22f;
    public Joystick joystick;
    Vector3 moveDirection = Vector3.zero;
    float gravity = 19;
    GameObject coconutObj;
    public AudioSource walkAudioSource;
    public AudioClip walkAudioClip;
        

    void Start()
    {
        boyObj = GameObject.Find("boy");
        coconutObj = GameObject.Find("Coconut_pos_0");
        anim = boyObj.GetComponent<Animator>();
        controller = transform.GetComponent<CharacterController>();
        boyObj.transform.position = coconutObj.transform.position;
        // LeanTween.move(boyObj, coconutObj.transform, 1.0f).setEase(LeanTweenType.easeOutQuad);
        Invoke("StartUpdating", 2);
        Invoke("GravityOff", 1);
        
    }

    bool doUpdate = false;

    void StartUpdating()
    {
        doUpdate = true;

    }

    void Update()
    {
        if (!doUpdate) return;
        Invoke("SetJoystic", 2);
        Invoke("SetGravity", 1);
    }

    public void SetJoystic() {
        
        //joystic
        if (controller.isGrounded)
        {

            Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

            if (moveVector != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveVector);
                anim.Play("run");
                walkAudioSource.PlayOneShot(walkAudioClip, 1f);
                //controller.SimpleMove(Vector3.forward * speed * 2);
                controller.transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
            }
            
        }
    }

    public void SetGravity()
    {
        //APPLY GRAVITY
        if (moveDirection.y > gravity * -1)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        controller.Move(moveDirection * Time.deltaTime);
        var left = transform.TransformDirection(Vector3.left);
    }

    public void GravityOff()
    {
        boyObj.GetComponent<Rigidbody>().useGravity = false;
    }

}

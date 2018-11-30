using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyControl : MonoBehaviour
{
    public Transform _startPos;
    public Joystick _myJoystick;
    public float _speed = 20f;

    float _gravity = 1000f;
    Rigidbody _playerRB;
    bool _isGrounded = false;
    CapsuleCollider _coli;

	// Use this for initialization
	void Start ()
    {
        _playerRB = GetComponent<Rigidbody>();
        _coli = GetComponent<CapsuleCollider>();
        transform.position = _startPos.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!_isGrounded)
        {
            Debug.Log("Me caigoooooooooo");
            
        }
        else
        {
            Debug.Log("Estoy en el suelo");
            MovePlayer();
        }
	}

    Vector3 moveDirection()
    {
        Vector3 _dir = (Vector3.right * _myJoystick.Horizontal + Vector3.forward * _myJoystick.Vertical);
        return _dir;
    }

    private void FixedUpdate()
    {
        Vector3 gra;

        if (_coli != null)
        {
            transform.position = _startPos.position;
            gra = Vector3.up * -_gravity * Time.deltaTime;
            _playerRB.AddRelativeForce(gra);
        }
        else
        {
            gra = Vector3.zero;
            _playerRB.AddRelativeForce(gra);
        }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ostion contra el sueloooooo");
        _isGrounded = true;
    }

    void MovePlayer()
    {
        Debug.Log("Me estoy moviendo");
        
        // !!!!!  falta combinar move direction con gravity
        transform.Translate(moveDirection() * _speed * Time.deltaTime,Space.World);
        transform.rotation = Quaternion.LookRotation(moveDirection());
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField] private float _runSpeed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveZ = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveZ = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }
        _moveDirection = new Vector3(moveX, moveY, moveZ).normalized;
    }

    private void FixedUpdate()
    {        
        if (IsGrounded())
        {
            _rigidbody.velocity = _moveDirection * _runSpeed;
        }
    } 
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 1f);
    }
}



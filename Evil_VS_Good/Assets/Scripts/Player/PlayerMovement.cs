using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IPlayerMovement
{
    [SerializeField] private float _speed;
    [SerializeField] private CharacterController _controller;

    public void MovePlayer()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));        
        _controller.Move(move * Time.deltaTime * _speed);
    }    
}



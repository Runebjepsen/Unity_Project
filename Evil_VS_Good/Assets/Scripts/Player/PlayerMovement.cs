using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour , IMovePlayer
{
    public void MovePlayer(CharacterController controller, bool grounded, int runSpeed)
    {        
        if (grounded)
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * runSpeed);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointer : MonoBehaviour
{
    public Vector3 mouseLocation { get; private set; }
    public void LookAtMouse(Transform player)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, LayerMask.GetMask("Terrain")))
        {
            mouseLocation = new Vector3(hit.point.x, player.position.y, hit.point.z);
            Vector3 forward = mouseLocation - player.position;
            player.LookAt(mouseLocation);            
        }
    }
}

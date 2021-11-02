using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition
{
    public Vector3 GetPosition(GameObject player)
    {
        int layerMask = LayerMask.GetMask("Terrain");
        var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(mouseRay, out var hit, Mathf.Infinity, layerMask))
        {
            float terrianHeight = hit.transform.gameObject.GetComponent<Collider>().bounds.size.y;
            float eyeLevel = terrianHeight + player.GetComponent<Collider>().bounds.size.y -1;
            
            return new Vector3(hit.point.x, eyeLevel, hit.point.z);

        }
        return Vector3.zero;
    }
    //public Vector3 GetEyeLevel(GameObject player)
    //{

    //}
}

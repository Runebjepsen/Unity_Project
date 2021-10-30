using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLocation : MonoBehaviour, IMousePointAt
{
    public Vector3 MousePointLocation(Ray MouseRay)
    {
        if (Physics.Raycast(MouseRay, out var hit, 1000))
        {
            return new Vector3(hit.point.x, 0, hit.point.z);
        }
        return Vector3.zero;
    }
}

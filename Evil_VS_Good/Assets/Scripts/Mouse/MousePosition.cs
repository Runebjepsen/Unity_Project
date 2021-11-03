using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    public static MousePosition Instance { get; private set; }
    
    private void Awake()
    {
        Instance = this;
    }
    public static Vector3 GetMouseWorldPosition => Instance.GetMouseWorldPosition_Instance();
    private Vector3 GetMouseWorldPosition_Instance()
    {        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit, 999f, _layerMask))
        {
            return hit.point;
        }
        return Vector3.zero;
    }
}

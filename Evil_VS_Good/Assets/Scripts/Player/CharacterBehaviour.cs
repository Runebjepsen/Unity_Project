using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    private MousePosition _mousePosition;

    private void Start()
    {
        _mousePosition = new MousePosition();
    }
    private void Update()
    {
        this.transform.LookAt(_mousePosition.GetPosition(this.gameObject));
    }
}

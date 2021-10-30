using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private bool _grounded;

    private IPlayerMovement _playerMovement;
    private IPlayerLookAt _playerLookAt;
    private IMousePointAt _mousePointAt;
    private IRayProvider _rayProvider;


    private void Awake()
    {
        _playerMovement = GetComponent<IPlayerMovement>();
        _playerLookAt = GetComponent<IPlayerLookAt>();
        _mousePointAt = GetComponent<IMousePointAt>();
        _rayProvider = GetComponent<IRayProvider>();
    }
    private void Update()
    {
        if (_grounded)
        {            
            _playerMovement.MovePlayer();
        }
        // Makes the playercharacter Look at the mouse point position.
        _playerLookAt.PlayerLookAtPoint(_mousePointAt.MousePointLocation(_rayProvider.CreateRay()));
    }
}

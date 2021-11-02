using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private bool _grounded;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private UnityEngine.CharacterController _controller;
    [SerializeField] private Rigidbody projectile;

    private PlayerMovement _playerMovement;
    private MousePosition _mousePosition;
    private FireBallBehaviour _fireball;

    private void Awake()
    {

    }
    private void Start()
    {
        _playerMovement = new PlayerMovement();
        _mousePosition = new MousePosition();
    }
    private void Update()
    {
        if (_grounded)
        {

            //transform.Translate(_playerMovement.GetNewMovePosition() * (_speed * Time.deltaTime));
            //_controller.Move(_playerMovement.GetNewMovePosition() * Time.deltaTime * _speed);
        }
        // Makes the playercharacter Look at the mouse point position.
        this.transform.LookAt(_mousePosition.GetPosition(this.gameObject));

        // new code
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody currentProjectile= Instantiate(projectile, this.transform.position, this.transform.rotation);
            currentProjectile.AddForce(this.gameObject.transform.forward * 10f * Time.deltaTime);
            Physics.IgnoreCollision(currentProjectile.GetComponent<Collider>(), GetComponent<Collider>());
            //GameObject projectile = Instantiate(_prefab, this.transform.position, this.transform.rotation);
            //Physics.IgnoreCollision(projectile.GetComponent<Collider>(), this.gameObject.GetComponent<Collider>());
            //_fireball = new FireBallBehaviour(this.gameObject.transform.forward);
        }


    }


    //new code
//            if (Input.GetKeyDown(KeyCode.Space))
//        {
//            _isDashButtonDown = true;
//        }
//if (_isDashButtonDown)
//{
//    Vector3 dashPosition = transform.position + _moveDirection * _dashAmount;

//    if (Physics.Raycast(transform.position, _moveDirection, out var hit, _dashAmount, _dashLayerMask))
//    {
//        dashPosition = hit.point;
//    }

//    _rigidbody.MovePosition(dashPosition);
//    _isDashButtonDown = false;
//}
}

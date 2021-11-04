using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private Vector3 _shootDir;
    private Vector3 _lastPosition;
    private float _maxTravelLength;
    private float _distanceTravelled;
    private float _moveSpeed = 20f;
    private GameObject _sender;
    public void Setup(Vector3 shootDir, float maxTravelLength, GameObject sender)
    {
        _shootDir = shootDir;
        _maxTravelLength = maxTravelLength;
        _sender = sender;
        _lastPosition = transform.position;
    }
    private void Update()
    {
        if (_distanceTravelled >= _maxTravelLength)
        {
            Object.Destroy(this.gameObject);
        }
        transform.position += _shootDir * _moveSpeed * Time.deltaTime;
        _distanceTravelled += Vector3.Distance(transform.position, _lastPosition);
        _lastPosition = transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _sender)
        {
            Physics.IgnoreCollision(_sender.GetComponent<Collider>(), GetComponent<Collider>());
        }
        else
            Object.Destroy(this.gameObject);
    }

}

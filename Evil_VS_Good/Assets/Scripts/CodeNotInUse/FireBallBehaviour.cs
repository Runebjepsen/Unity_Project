using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallBehaviour : MonoBehaviour
{
    [SerializeField] private float _fireBallSpeed;
    public Vector3 Direction { get; private set; }

    public FireBallBehaviour(Vector3 playerDirection)
    {
        Direction = playerDirection;
    }
    void Update()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(Direction * _fireBallSpeed * Time.deltaTime);
        //Rigidbody projectileRB = this.GetComponent<Rigidbody>();
        //projectileRB.AddForce()
        //projectileRB.velocity = this.gameObject.transform.forward * _fireBallSpeed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private Vector3 shootDir;
    private GameObject shooter;

    public void Setup(Vector3 shootDir, GameObject shooter)
    {
        this.shootDir = shootDir;
        this.shooter = shooter;
    } 

    //void Update()
    //{
    //    float moveSpeed = 100f;
    //    transform.position += shootDir * moveSpeed * Time.deltaTime;
    //}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //Debug.Log(collision.gameObject.name);
    //    if (collision.gameObject == shooter)
    //    {
    //        Physics.IgnoreCollision(transform.GetComponent<Collider>(), shooter.transform.GetComponent<Collider>());
    //    }
    //}
}

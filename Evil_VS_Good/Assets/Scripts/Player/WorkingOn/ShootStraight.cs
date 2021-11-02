using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStraight : MonoBehaviour
{
    public void ShootForwardOrBackwards(GameObject projectile, float speed, int direction)
    {
        Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();
        projectileRB.velocity = (projectile.transform.forward * direction) * speed * Time.deltaTime;
        //projectileRB.AddForce((projectile.transform.forward * direction) * speed * Time.deltaTime);
    }
    public void ShootLeftOrRight(GameObject projectile, float speed, int direction)
    {
        Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();
        projectileRB.velocity = (projectile.transform.right * direction) * speed * Time.deltaTime;
        //projectileRB.AddForce((projectile.transform.forward * direction) * speed * Time.deltaTime);
    }

}

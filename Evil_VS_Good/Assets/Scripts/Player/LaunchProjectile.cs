using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour, ILaunchProjectile
{
    private SpellCollection spellCollection;
    private MousePointer mousePointer;

    public void ShootInALine()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            mousePointer = FindObjectOfType<MousePointer>();
            spellCollection = FindObjectOfType<SpellCollection>();

            GameObject projectile = Instantiate(
                spellCollection.Fireball,
                transform.position,
                Quaternion.identity);
            
            Vector3 shootDir = (mousePointer.mouseLocation - transform.position).normalized;

            projectile.GetComponent<Fireball>().Setup(shootDir, transform.gameObject);
            Object.Destroy(projectile, 3f);

        }
    }
}

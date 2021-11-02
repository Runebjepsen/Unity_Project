using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateProjectile : MonoBehaviour
{
    public GameObject CreateProjectile(GameObject prefab, Vector3 spawnLocation, GameObject creator)
    {
        GameObject projectile = Instantiate(prefab, spawnLocation, creator.transform.rotation);
        Physics.IgnoreCollision(projectile.GetComponent<Collider>(), creator.GetComponent<Collider>());
        return projectile;
    }
}

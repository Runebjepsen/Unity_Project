using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private Vector3 _shootDir;
    public void Setup(Vector3 shootDir)
    {
        _shootDir = shootDir;
    }
    private void Update()
    {
        float moveSpeed = 30f;
        transform.position += _shootDir * moveSpeed * Time.deltaTime;
        Object.Destroy(this.gameObject, 2.0f);
    }

}

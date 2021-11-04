using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _pfFireball;
    [SerializeField] private Transform _pfMonster;
    private void Update()
    {
        this.transform.LookAt(CreateEyeLevelOfMousePosition());

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Shoot straight projectile
            Transform fireballTransform = Instantiate(_pfFireball, this.transform.GetChild(1).position, this.transform.rotation);;
            Vector3 shootDir = this.transform.forward;
            float distance = Vector3.Distance(CreateEyeLevelOfMousePosition(), this.transform.position);
            fireballTransform.GetComponent<Fireball>().Setup(shootDir, distance, this.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Spawn monster
            if (GameObject.Find(_pfMonster.name + "(Clone)") != null)
            {
                Object.Destroy(GameObject.Find(_pfMonster.name + "(Clone)"));
            }
            Transform allyMonster = Instantiate(_pfMonster, CreateEyeLevelOfMousePosition(), Quaternion.Inverse(this.transform.rotation));

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Shoot Instant

        }
    }
    private Vector3 CreateEyeLevelOfMousePosition()
    {
        Vector3 currentMousePosition = MousePosition.GetMouseWorldPosition;
        currentMousePosition.y = this.GetComponent<Collider>().bounds.size.y - 1;
        return currentMousePosition;
    } 


}

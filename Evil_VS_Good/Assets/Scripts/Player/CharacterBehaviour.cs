using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _pfFireball;
    private void Update()
    {
       playerLookAt();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Transform fireballTransform = Instantiate(_pfFireball, this.transform.position, this.transform.rotation);
            Vector3 shootDir = this.transform.forward;
            fireballTransform.GetComponent<Fireball>().Setup(shootDir);
            Physics.IgnoreCollision(fireballTransform.GetComponent<Collider>(), GetComponent<Collider>());

        }
    }
    private void playerLookAt()
    {
        Vector3 currentMousePosition = MousePosition.GetMouseWorldPosition;
        currentMousePosition.y = this.GetComponent<Collider>().bounds.size.y - 1;
        this.transform.LookAt(currentMousePosition);
    }


}

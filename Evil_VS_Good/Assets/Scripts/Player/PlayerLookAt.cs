using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAt : MonoBehaviour, IPlayerLookAt
{
    [SerializeField] GameObject _player;
    public void PlayerLookAtPoint(Vector3 point)
    {
        point.y = _player.transform.position.y;
        _player.transform.LookAt(point);
    }
}

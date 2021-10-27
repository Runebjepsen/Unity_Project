using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerControl
{
    void LookAtMouse(Transform player);
}
public interface IMovePlayer
{
    void MovePlayer(CharacterController controller, bool grounded, int runSpeed);
}
public interface ILaunchProjectile
{
    void ShootInALine();
}

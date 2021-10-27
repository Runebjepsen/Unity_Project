using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] private bool grounded;
    [SerializeField] private int runSpeed;
    MousePointer mousePointer;
    PlayerMovement playerMovement;
    LaunchProjectile launchProjectile;

    void Start()
    {
        mousePointer = gameObject.AddComponent(typeof(MousePointer)) as MousePointer;
        playerMovement = gameObject.AddComponent(typeof(PlayerMovement)) as PlayerMovement;
        launchProjectile = gameObject.AddComponent(typeof(LaunchProjectile)) as LaunchProjectile;
    }

    void Update()
    {
        PlayerLookAt(mousePointer);
        MovePlayer(playerMovement);
        PlayerShoot(launchProjectile);

    }
    private void PlayerLookAt(IPlayerControl playerControl)
    {
        playerControl.LookAtMouse(this.transform);
    }
    private void MovePlayer(IMovePlayer movePlayer)
    {
        movePlayer.MovePlayer(controller, grounded, runSpeed);
    }
    private void PlayerShoot(ILaunchProjectile launchProjectile)
    {
        launchProjectile.ShootInALine();
    }
}

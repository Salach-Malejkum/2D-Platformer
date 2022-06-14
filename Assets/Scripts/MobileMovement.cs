using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileMovement : MonoBehaviour
{

    public GameObject player;
    public GameObject objects;
    private PlayerController playerController;
    private ObjectsScript objectsScripts;

    // Start is called before the first frame update
    void Start()
    {
        playerController = player.GetComponent<PlayerController>();
        objectsScripts = objects.GetComponent<ObjectsScript>();
    }

    // Update is called once per frame
    void Update()
    {
        playerController.Movement();
        objectsScripts.Move();
    }

    // TODO
    // public void Jump()
    // {
    //     playerController.Jump(true);
    // }

    public void MovementLeftPress()
    {
        playerController.movementLeft = true;
        objectsScripts.movementLeft = true;
    }

    public void MovementLeftRelease()
    {
        playerController.movementLeft = false;
        objectsScripts.movementLeft = false;
    }

    public void MovementRightPress()
    {
        playerController.movementRight = true;
        objectsScripts.movementRight = true;
    }

    public void MovementRightRelease()
    {
        playerController.movementRight = false;
        objectsScripts.movementRight = false;
    }
}

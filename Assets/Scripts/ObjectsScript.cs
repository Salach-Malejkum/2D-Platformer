using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsScript : MonoBehaviour
{
    public bool canMove = true;
    public int speed = 4;
    public bool movementLeft = false;
    public bool movementRight = false;

    // Update is called once per frame
    void Update()
    {
        // if (canMove)
        //     Move();
    }

    public void Move()
    {
        if (!canMove)
        {
            return;
        }

        if (Input.GetKey(KeyCode.A) || movementLeft)
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D) || movementRight)
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float speed = 10.0f;
    float turnSpeed = 50.0f;

    bool moveForward = false;
    bool moveBackward = false;
    bool turnLeft = false;
    bool turnRight = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        if(Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }
        if(Input.GetKey(KeyCode.A))
        {
            TurnLeft();
        }
        if(Input.GetKey(KeyCode.D))
        {
            TurnRight();
        }

        if(moveForward)
        {
            MoveForward();
        }
        if(moveBackward)
        {
            MoveBackward();
        }
        if(turnLeft)
        {
            TurnLeft();
        }
        if(turnRight)
        {
            TurnRight();
        }
    }

    public void MoveForward()
    {
        transform.localPosition += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;
    }

    public void MoveBackward()
    {
        transform.localPosition -= transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;
    }

    public void TurnLeft()
    {
        transform.Rotate(0.0f, -turnSpeed * Time.deltaTime, 0.0f);
    }

    public void TurnRight()
    {
        transform.Rotate(0.0f, turnSpeed * Time.deltaTime, 0.0f);
    }

    public void startForward()
    {
        moveForward = true;
    }
    public void endForward()
    {
        moveForward = false;
    }
    public void startBackward()
    {
        moveBackward = true;
    }

    public void endBackward()
    {
        moveBackward = false;
    }
    public void startLeft()
    {
        turnLeft = true;
    }
    public void endLeft()
    {
        turnLeft = false;
    }
    public void startRight()
    {
        turnRight = true;
    }
    public void endRight()
    {
        turnRight = false;
    }

}

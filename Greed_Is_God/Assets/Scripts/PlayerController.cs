﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float xVel;
    public float yVel;

    public float xRot;
    public float yRot;

    public float moveSpeed;

    private Rigidbody rb;

    public bool player1;
    public bool player2;

    private PManager PM;

    void Awake()
    {
        PM = gameObject.GetComponent<PManager>();
        rb = GetComponent<Rigidbody>();
        JoystickCheck();
    }

    void Update()
    {
        if (player1 == true)
        {
            GetInputP1();
        }

        if (player2 == true)
        {
            GetInputP2();
        }

        OverrideRotation();

        //Stops the player from snapping back to 0 rotation
        if (Mathf.Abs(xVel) < 1 && Mathf.Abs(yVel) < 1)
            return;

        Move();   
    }

    void JoystickCheck()
    {
        if (gameObject.name == "Player_1")
        {
            player1 = true;
            print("Player 1 Connected");
        }

        if (gameObject.name == "Player_2")
        {
            player2 = true;
            print("Player 2 Connected");
        }
    }

    void GetInputP1()
    {
        //Left analogue sick movement
        xVel = Input.GetAxis("LeftJoystickHorizontal_1") * moveSpeed;
        yVel = Input.GetAxis("LeftJoystickVertical_1") * moveSpeed;

        //Right analogue sick movement
        xRot = Input.GetAxisRaw("RightJoystickHorizontal_1");
        yRot = Input.GetAxisRaw("RightJoystickVertical_1");

        if (xRot != 0 || yRot != 0)
            PM.Shoot();
    }

    void GetInputP2()
    {
        //Left analogue sick movement
        xVel = Input.GetAxis("LeftJoystickHorizontal_2") * moveSpeed;
        yVel = Input.GetAxis("LeftJoystickVertical_2") * moveSpeed;

        //Right analogue sick movement
        xRot = Input.GetAxisRaw("RightJoystickHorizontal_2");
        yRot = Input.GetAxisRaw("RightJoystickVertical_2");

        if (xRot != 0 || yRot != 0)
            PM.Shoot();
    }

    void OverrideRotation()
    {
        //Stops the player from snapping back to 0 rotation
        if (xRot == 0 && (yRot) == 0)
            return;

        //For aim while standing still
        Vector3 lookDirection = new Vector3(xRot, 0, yRot);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.5f);
        
    }

    void Move()
    {
        rb.velocity = new Vector3(xVel , 0, yVel);

        //Makes the player look in the move direction unless there is input in the right analogue stick
        if (xRot == 0 && yRot == 0)
        {
            //So player faces the move direction
            Vector3 movement = new Vector3(xVel, 0.0f, yVel);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 1);
        }
        else
        {
            //For aim while moving 
            Vector3 lookDirection = new Vector3(xRot, 0, yRot);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.5f);
        }
    }
}

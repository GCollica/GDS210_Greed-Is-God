using System.Collections;
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

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        //Vector3 lookDirection = new Vector3(xRot, 0, yRot);
        //Vector3 movement = new Vector3(xVel, 0.0f, yVel);
        //if (xVel != 0 || yVel != 0)
        //{
        //    transform.rotation = Quaternion.LookRotation(lookDirection, Vector3.back);
        //}
    }

    void Update()
    {
        CharacterMove();   
    }

    void CharacterMove()
    {
        xVel = Input.GetAxis("LeftJoystickHorizontal");
        yVel = Input.GetAxis("LeftJoystickVertical");

        xRot = Input.GetAxisRaw("RightJoystickHorizontal");
        yRot = Input.GetAxisRaw("RightJoystickVertical");

        rb.velocity = new Vector3(xVel * moveSpeed, 0, yVel * moveSpeed);

        if (xRot == 0 && yRot == 0)
        {
            //For making the player look in the direction of the left analogue stick
            Vector3 movement = new Vector3(xVel, 0.0f, yVel);
            transform.rotation = Quaternion.LookRotation(movement);
        }
        else
        {
            //For making the player look in the direction of the right analogue stick
            Vector3 lookDirection = new Vector3(xRot, 0, yRot);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.5f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float xVel;
    public float yVel;
    public float moveSpeed;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        xVel = Input.GetAxis("LeftJoystickHorizontal");
        yVel = Input.GetAxis("LeftJoystickVertical");

        rb.velocity = new Vector3(xVel * moveSpeed, 0, yVel * moveSpeed);   
    }

    void Rotate()
    {
        //Vector3 lookDirection = new Vector3(Input.GetAxisRaw("RightJoystickHorizontal"), 0, Input.GetAxisRaw("RightJoystickVertical"));
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.15f);

        //xVel = Input.GetAxis("LeftJoystickHorizontal");
        //yVel = Input.GetAxis("LeftJoystickVertical");

        //Vector3 movement = new Vector3(xVel, 0.0f, yVel);
        //transform.rotation = Quaternion.LookRotation(movement);

        //transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);
    }
}

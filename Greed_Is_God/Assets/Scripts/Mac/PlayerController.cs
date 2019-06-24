using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float xVel;
    public float yVel;
    public float speed;

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
    }

    void Move()
    {
        xVel = Input.GetAxis("LeftJoystickHorizontal");
        yVel = Input.GetAxis("LeftJoystickVertical");

        rb.velocity = new Vector3(xVel * speed, 0, yVel * speed);   
    }
}

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

    public bool player1;
    public bool player2;
    public bool player3;
    public bool player4;

    private int score;

    public GreedGod greedGod;
    private PManager pManager;

    void Awake()
    {
        pManager = gameObject.GetComponent<PManager>();
        rb = GetComponent<Rigidbody>();
        JoystickCheck();
    }

    void Update()
    {
        PlayerActivate();
        //StoreScore();
        OverrideRotation();

        score = pManager.goldCount;

        //Stops the player from snapping back to 0 rotation
        if (Mathf.Abs(xVel) < 1 && Mathf.Abs(yVel) < 1)
            return;

        Move();   
    }

    //Checks if each player is in the level
    //There will be a menu to pick if the players corresponding player game object is in the scene before this check is called
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

        if (gameObject.name == "Player_3")
        {
            player3 = true;
            print("Player 3 Connected");
        }

        if (gameObject.name == "Player_4")
        {
            player4 = true;
            print("Player 4 Connected");
        }
    }

    //Assigns each player to their coresponding joystick movement
    void PlayerActivate()
    {
        if (player1 == true)
        {
            GetInputP1();
            greedGod.player1score = score;
        }

        if (player2 == true)
        {
            GetInputP2();
            greedGod.player2score = score;
        }

        if (player3 == true)
        {
            GetInputP3();
            greedGod.player3score = score;
        }

        if (player4 == true)
        {
            GetInputP4();
            greedGod.player4score = score;
        }
    }

    //Player 1 inputs
    void GetInputP1()
    {
        //Left analogue sick movement
        xVel = Input.GetAxis("LeftJoystickHorizontal_1") * moveSpeed;
        yVel = Input.GetAxis("LeftJoystickVertical_1") * moveSpeed;

        //Right analogue sick movement
        xRot = Input.GetAxisRaw("RightJoystickHorizontal_1");
        yRot = Input.GetAxisRaw("RightJoystickVertical_1");

        if (xRot != 0 || yRot != 0)
            pManager.Shoot();
    }

    //Player 2 inputs
    void GetInputP2()
    {
        //Left analogue sick movement
        xVel = Input.GetAxis("LeftJoystickHorizontal_2") * moveSpeed;
        yVel = Input.GetAxis("LeftJoystickVertical_2") * moveSpeed;

        //Right analogue sick movement
        xRot = Input.GetAxisRaw("RightJoystickHorizontal_2");
        yRot = Input.GetAxisRaw("RightJoystickVertical_2");

        if (xRot != 0 || yRot != 0)
            pManager.Shoot();
    }

    //Player 3 inputs
    void GetInputP3()
    {
        //Left analogue sick movement
        xVel = Input.GetAxis("LeftJoystickHorizontal_3") * moveSpeed;
        yVel = Input.GetAxis("LeftJoystickVertical_3") * moveSpeed;

        //Right analogue sick movement
        xRot = Input.GetAxisRaw("RightJoystickHorizontal_3");
        yRot = Input.GetAxisRaw("RightJoystickVertical_3");

        if (xRot != 0 || yRot != 0)
            pManager.Shoot();
    }

    //Player 4 inputs
    void GetInputP4()
    {
        //Left analogue sick movement
        xVel = Input.GetAxis("LeftJoystickHorizontal_4") * moveSpeed;
        yVel = Input.GetAxis("LeftJoystickVertical_4") * moveSpeed;

        //Right analogue sick movement
        xRot = Input.GetAxisRaw("RightJoystickHorizontal_4");
        yRot = Input.GetAxisRaw("RightJoystickVertical_4");

        if (xRot != 0 || yRot != 0)
            pManager.Shoot();
    }

    //For aim when not moving
    void OverrideRotation()
    {
        //Stops the player from snapping back to 0 rotation
        if (xRot == 0 && (yRot) == 0)
            return;

        //Allows player to aim and shoot while stationary
        Vector3 lookDirection = new Vector3(xRot, 0, yRot);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.5f);
        
    }

    //For player aim while moving
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
            //Allows player to aim and shoot while moving
            Vector3 lookDirection = new Vector3(xRot, 0, yRot);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bounds"))
        {
            this.gameObject.transform.position = greedGod.currentGreedGod.transform.position;
        }
    }

}

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

    public List<int> scores;
    public int player1score;
    public int player2score;
    public int player3score;
    public int player4score;
    public int greedGod;

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
        OverrideRotation();
        //StoreScore();

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
            return;
        }

        if (player2 == true)
        {
            GetInputP2();
            return;
        }

        if (player3 == true)
        {
            GetInputP2();
            return;
        }

        if (player4 == true)
        {
            GetInputP2();
            return;
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
        xVel = Input.GetAxis("LeftJoystickHorizontal_2") * moveSpeed;
        yVel = Input.GetAxis("LeftJoystickVertical_2") * moveSpeed;

        //Right analogue sick movement
        xRot = Input.GetAxisRaw("RightJoystickHorizontal_2");
        yRot = Input.GetAxisRaw("RightJoystickVertical_2");

        if (xRot != 0 || yRot != 0)
            pManager.Shoot();
    }

    //Player 4 inputs
    void GetInputP4()
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


    void StoreScore()
    {
        if (player1 == true)
        {
            player1score = pManager.goldCount;
        }

        if (player2 == true)
        {
            player2score = pManager.goldCount; ;
        }

        if (player3 == true)
        {
            player3score = pManager.goldCount; ;
        }

        if (player4 == true)
        {
            player4score = pManager.goldCount; ;
        }

        scores.Add(player1score);
        scores.Add(player2score);
        scores.Add(player3score);
        scores.Add(player4score);

        scores.Sort();


        for (int i = scores.Count; i-- > 0;)
        {
            greedGod = scores[1];
            print(greedGod);
        }
    }
}

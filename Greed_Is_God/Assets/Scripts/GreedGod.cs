using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreedGod : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    public int player1score;
    public int player2score;
    public int player3score;
    public int player4score;

    public int greedGodScore;

    private PlayerController pController;
    public CameraController cController;

    void Start()
    {
        greedGodScore = 0;
    }

    void Update()
    {
        DetermineGreedGod();
    }

    //Checks if each players score is higher than the current required score to be the Greed God. 
    //If player has a score higher than the Greed Gods required score, it sets the cameras target to that player and replaces the Greed God score to the players score
    void DetermineGreedGod()
    {
        //For Player 1
        if(player1score > greedGodScore)
        {           
            cController.target = Player1.transform;
            greedGodScore = player1score;
        }

        //For Player 2
        if (player2score > greedGodScore)
        {
            cController.target = Player2.transform;
            greedGodScore = player2score;
        }

        //For Player 3
        if (player3score > greedGodScore)
        {
            cController.target = Player3.transform;
            greedGodScore = player3score;
        }

        //For Player 4
        if (player4score > greedGodScore)
        {
            cController.target = Player4.transform;
            greedGodScore = player4score;
        }
    }
}

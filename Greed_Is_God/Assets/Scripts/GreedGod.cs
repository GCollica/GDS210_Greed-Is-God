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
    public GameObject currentGreedGod;

    private PlayerController pController;
    public CameraController cController;

    private void Awake()
    {
        currentGreedGod = Player1;
    }

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
            greedGodScore = player1score;
            currentGreedGod = Player1;
        }

        //For Player 2
        if (player2score > greedGodScore)
        {
            greedGodScore = player2score;
            currentGreedGod = Player2;
        }

        //For Player 3
        if (player3score > greedGodScore)
        {
            greedGodScore = player3score;
            currentGreedGod = Player3;
        }

        //For Player 4
        if (player4score > greedGodScore)
        {
            greedGodScore = player4score;
            currentGreedGod = Player4;
        }
    }
}

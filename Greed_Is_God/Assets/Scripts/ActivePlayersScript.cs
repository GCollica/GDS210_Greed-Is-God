using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayersScript : MonoBehaviour
{
    public GameObject Player1, Player2, Player3, Player4;

    public bool onePlayer;
    public bool twoPlayers;
    public bool threePlayers;
    public bool fourPlayers;

    // Start is called before the first frame update
    void Start()
    {
        Player1.SetActive(false);
        Player2.SetActive(false);
        Player3.SetActive(false);
        Player4.SetActive(false);

        onePlayer = false;
        twoPlayers = false;
        threePlayers = false;
        fourPlayers = false;

        if(onePlayer == true)
        {
            Player1.SetActive(true);
        }



    }
}

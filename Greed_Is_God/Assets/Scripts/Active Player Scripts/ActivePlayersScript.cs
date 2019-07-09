using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayersScript : MonoBehaviour
{
    ActivePlayerRoster APRScript;
        
    GameObject Player1, Player2, Player3, Player4;

    public bool onePlayer;
    public bool twoPlayers;
    public bool threePlayers;
    public bool fourPlayers;

    void Update()
    {
        if (onePlayer == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(false);
            Player3.SetActive(false);
            Player4.SetActive(false);
            Debug.Log("p1 active");
        }

        if (twoPlayers == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(false);
            Player4.SetActive(false);
            Debug.Log("p1,2 active");
        }

        if (threePlayers == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(false);
            Debug.Log("p1,2,3 active");
        }

        if (fourPlayers == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(true);
            Debug.Log("p1,2,3,4 active");
        }
    }
}

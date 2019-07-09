using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayers : MonoBehaviour
{
    public GameObject Player1, Player2, Player3, Player4;
    private int numberOfPlayers;

    ActivePlayersScript aPScript;

    // Start is called before the first frame update
    void Awake()
    {
        aPScript = FindObjectOfType<ActivePlayersScript>();
        PlayerCountCheck();
        SpawnPlayers();
    }

    void PlayerCountCheck()
    {
        if(aPScript.onePlayer == true)
        {
            numberOfPlayers = 1;
        }
        if(aPScript.twoPlayers == true)
        {
            numberOfPlayers = 2;
        }
        if(aPScript.threePlayers == true)
        {
            numberOfPlayers = 3;
        }
        if (aPScript.fourPlayers == true)
        {
            numberOfPlayers = 4;
        }
    }

    void SpawnPlayers()
    {
        if (numberOfPlayers == 1)
        {
            Player1.SetActive(true);
            Player2.SetActive(false);
            Player3.SetActive(false);
            Player4.SetActive(false);
            Debug.Log("p1 active");
        }

        if (numberOfPlayers == 2)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(false);
            Player4.SetActive(false);
            Debug.Log("p1-2 active");
        }

        if (numberOfPlayers == 3)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(false);
            Debug.Log("p1-3 active");
        }

        if (numberOfPlayers == 4)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(true);
            Debug.Log("p1-4 active");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayersScript : MonoBehaviour
{
    public GameObject Player1, Player2, Player3, Player4;

    public bool onePlayer = false;
    public bool twoPlayers = false;
    public bool threePlayers = false;
    public bool fourPlayers = false;

    // Start is called before the first frame update
    void Start()
    {
        //Player1.SetActive(false);
        //Player2.SetActive(false);
        //Player3.SetActive(false);
        //Player4.SetActive(false);
    }

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
        }

        if (threePlayers == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(false);
        }

        if (fourPlayers == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(true);
        }
    }
}

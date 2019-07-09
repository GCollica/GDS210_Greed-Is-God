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
            Debug.Log("p1-2 active");
        }

        if (threePlayers == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(false);
            Debug.Log("p1-3 active");
        }

        if (fourPlayers == true)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(true);
            Debug.Log("p1-4 active");
        }
        DontDestroyOnLoad(this.gameObject);
    }
}

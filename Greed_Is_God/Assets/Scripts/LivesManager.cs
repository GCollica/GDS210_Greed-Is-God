using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public int livesRemaining = 5;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public GameObject LoseScreen;
    void Update()
    {
        EndGame();
    }

    void EndGame()
    {
        if(livesRemaining == 0 && player1.activeInHierarchy == false && player2.activeInHierarchy == false && player3.activeInHierarchy == false && player4.activeInHierarchy == false)
        {
            LoseScreen.SetActive(true);
        }
    }
}

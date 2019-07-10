using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    public int livesRemaining;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public Text livesText;

    public GameObject LoseScreen;

    private void Start()
    {
        livesRemaining = 5;
    }


    void Update()
    {
        livesText.text = livesRemaining.ToString();

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

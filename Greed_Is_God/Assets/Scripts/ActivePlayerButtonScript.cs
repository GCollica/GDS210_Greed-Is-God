using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ActivePlayerButtonScript : MonoBehaviour
{
    //public GameObject ActivePlayerManager;
    public ActivePlayersScript APScript;


    public void onePlayer()
    {
        Debug.Log("1");
        if (APScript.onePlayer == false)
        {
            Debug.Log("1Changing");
            APScript.onePlayer = true;
            SceneManager.LoadScene("Level_One");
        }
    }

    public void twoPlayers()
    {
        Debug.Log("2");
        if (APScript.twoPlayers == false)
        {
            Debug.Log("2Changing");
            APScript.twoPlayers = true;
            SceneManager.LoadScene("Level_One");
        }
    }

    public void threePlayers()
    {
        Debug.Log("3");
        if (APScript.threePlayers == false)
        {
            Debug.Log("3Changing");
            APScript.threePlayers = true;
            SceneManager.LoadScene("Level_One");
        }
    }

    public void fourPlayers()
    {
        Debug.Log("4");
        if (APScript.fourPlayers == false)
        {
            Debug.Log("4Changing");
            APScript.fourPlayers = true;
            SceneManager.LoadScene("Level_One");
        }
    }
}

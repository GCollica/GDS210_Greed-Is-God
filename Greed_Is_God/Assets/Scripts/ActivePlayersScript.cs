using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayersScript : MonoBehaviour
{
    public bool onePlayer = false;
    public bool twoPlayers = false;
    public bool threePlayers = false;
    public bool fourPlayers = false;

    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

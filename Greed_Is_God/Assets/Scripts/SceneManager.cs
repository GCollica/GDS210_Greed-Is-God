using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void mainMenu (string mainMenu)
    {
        SceneManager.LoadScene ("MainMenu");
    }

    public void LoadPlayers(string players)
    {
        SceneManager.LoadScene ("Players");
    }

    public void LoadLevelSelect(string leve)
    {
        SceneManager.LoadScene ("LevelSelect");
    }

    public void levelOne(string LevelOne)
    {
        SceneManager.LoadScene ("Level One");
    }

    void LevelTwo()
    {

    }

    void LevelThree()
    {

    }

    void LevelFour()
    {

    }
}

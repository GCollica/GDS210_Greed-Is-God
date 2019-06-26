using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene("Mac's_Alpha");
    }

    public void ControlsButton()
    {
        SceneManager.LoadScene("Controls");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == ("Controls") && Input.GetButtonDown("BackButton"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
   
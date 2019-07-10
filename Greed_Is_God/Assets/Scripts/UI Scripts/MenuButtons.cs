using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{

    public void SceneButton(string myInput)
    {
        SceneManager.LoadScene(myInput);
        Debug.Log("pressed");
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == ("Controls") && Input.GetButtonDown("BackButton"))
        {
            SceneManager.LoadScene("MainMenu");
        }
        /*
        if (scene.name == ("Level_One") && Input.GetButtonDown("PauseButton"))
        {
            SceneManager.LoadScene("PauseMenu");
        }
        */
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
   
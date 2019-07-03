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
   
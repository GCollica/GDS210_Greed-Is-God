using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoScore : MonoBehaviour
{
    public static int scoreValue = 0;
    Text ScoreTwo;

    // Start is called before the first frame update
    void Start()
    {
        ScoreTwo = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTwo.text = "$" + scoreValue;
    }
}
